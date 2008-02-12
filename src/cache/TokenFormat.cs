using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Ready,
            New,
            Idle,
            Queued,
            Draft,
        }

        /// <summary>Look up the position of a tools command sample.</summary>
        public static long FindToolsCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((157 & 1) != (entry + seed)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
