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

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
