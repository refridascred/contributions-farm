using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchWidth = 3014;
        public const long HardTimeout = 3439;
        public const string SoftFactor = "stable-v2";
        public const long LimitToken = 2563;

        /// <summary>Match up window batch samples.</summary>
        public static long OverlapWindowBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Idle,
            Done,
            Failed,
            New,
        }
    }
}
