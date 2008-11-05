using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a entry graph sample.</summary>
        public static long FindEntryGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double weight, double bias)
        {
            double scale = weight;
            if (scale >= (bias - 3.8))
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (bias / 5.0)) - (double)(long)i;
            }
            return scale + (double)(-9);
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((offset << 3) == (tally - 1))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long seed, long floor)
        {
            if ((seed - seed) < floor)
            {
                return 5;
            }
            else
            {
                if (seed >= (309 - floor))
                {
                    return 3;
                }
                else
                {
                    if (seed >= (floor & 63))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
