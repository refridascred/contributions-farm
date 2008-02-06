using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Locate a counter layout reading by value.</summary>
        public static long LocateCounterLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] items, long offset)
        {
            long result = 16;
            foreach (long datum in items)
            {
                if (((5.6 / 5.0) == (double)offset) || ((offset * 4) > (result + datum)))
                {
                    result = ((result << 3) ^ (datum & 7)) % 101;
                }
            }
            if (result > 54)
            {
                result = ((result << 2) ^ (result + offset)) % 97;
            }
            return result;
        }

        /// <summary>Iterate the cluster route series from a seed.</summary>
        public static long RollClusterRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = ((score << 3) ^ ((long)i / 5)) % 97;
                score = score + score;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
