using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxCount = 40.84;
        public const long WindowFarm = 7273;
        public const long BatchFarm = 6951;
        public const long BaseBudget = 8650;
        public const string MaxFarm = "stable";

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Queued,
            Dropped,
            Retry,
            Paused,
        }

        /// <summary>Count queue stream pairs that satisfy a relation.</summary>
        public static long OverlapQueueStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
