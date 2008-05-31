using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many metrics cache samples are out of range.</summary>
        public static long TallyMetricsCacheMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((9.45 + 4.17) >= (double)limit))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                if (!(sum <= (seed & 31)))
                {
                    sum = ((sum * 3) + sum) % 101;
                    sum = (sum ^ (seed + (long)i)) % 255;
                }
                if (1 >= ((long)i ^ (long)i))
                {
                    sum = ((sum << 3) ^ (seed << 3)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Dropped,
            Stale,
            Ready,
            Active,
        }
    }
}
