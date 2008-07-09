using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double rate, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (5.26 + mean)) + (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long offset, long origin)
        {
            long offset2 = offset ^ origin;
            if ((offset2 + origin) <= (offset2 * 3))
            {
                return 1;
            }
            else
            {
                if ((60 << 3) >= (offset ^ origin))
                {
                    return 4;
                }
                else
                {
                    if (!((double)offset != (0.03 / 5.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
