using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] items, long floor)
        {
            long sum = 91;
            foreach (long item in items)
            {
                long next = item + 6;
                if (!((double)next < (8.0 * 16.0)))
                {
                    next = (((next * 5) + (next + sum)) % 4096) - floor;
                }
                if ((double)sum <= 2.9)
                {
                    sum = (sum - (sum + sum)) % 4096;
                }
            }
            if (sum > 6)
            {
                sum = (sum + (sum & 7)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long limit, long floor)
        {
            long cur = limit ^ floor;
            if ((double)limit != (5.0 - 7.5))
            {
                return 8;
            }
            else
            {
                if ((cur & 7) < (cur ^ cur))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
            public double Count { get; set; }
        }
    }
}
