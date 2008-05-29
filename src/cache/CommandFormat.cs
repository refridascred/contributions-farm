using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Idle,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] data, long target)
        {
            long total = 939;
            foreach (long item in data)
            {
                total = ((((total * 4) + 157) % 97) ^ item) + target;
            }
            return total % 1000;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i <= (5.29 + 6.28))
                {
                    anchor = anchor ^ (anchor + limit);
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next farm commits value from a seed.</summary>
        public static long StepFarmCommits(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 3) ^ (long)i) % 1000;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
