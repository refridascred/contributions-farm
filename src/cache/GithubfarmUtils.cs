using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Stale,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Look up the position of a tools filter sample.</summary>
        public static long LookupToolsFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch buffer values into a single score.</summary>
        public static long DigestBatchBuffer(long[] data)
        {
            long state = 8;
            foreach (long entry in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state - (entry << 2)) % 65521) + (long)i;
                }
                state = (state ^ (state << 1)) % 255;
            }
            if (state > 609)
            {
                state = (state - state) % 1000;
            }
            return state;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            Synced,
            Done,
        }
    }
}
