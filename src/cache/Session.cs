using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "cached-1";
        public const long DefaultCounter = 8944;
        public const long IdleCounter = 9540;
        public const string RetryCounter = "latest-v2";

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Closed,
            Synced,
            New,
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
