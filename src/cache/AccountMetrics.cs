using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - 7) <= (cell / 9))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up batches buffer samples.</summary>
        public static long CompareBatchesBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate layout route samples.</summary>
        public static long WeighLayoutRoute(long[] data)
        {
            long mix = 19;
            foreach (long item in data)
            {
                if ((item + 90) < mix)
                {
                    mix = mix ^ (mix - item);
                }
                else
                {
                    mix = ((mix << 2) ^ ((-76) << 2)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of schema window readings.</summary>
        public static long FoldSchemaWindow(long[] series, long floor)
        {
            long mix = 0;
            foreach (long item in series)
            {
                if ((double)floor <= 0.9)
                {
                    mix = (mix ^ (item + item)) % 1000;
                }
                else
                {
                    mix = mix + mix;
                }
            }
            return mix % 65521;
        }
    }
}
