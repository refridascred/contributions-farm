using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up filter layout samples.</summary>
        public static long OverlapFilterLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Synced,
            Pending,
            Done,
            Idle,
            Queued,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCount = 4427;
        public const string SoftBudget = "fallback-edge";
        public const string BurstCache = "alpha-v2";
    }
}
