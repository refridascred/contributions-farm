using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Active,
            Retry,
            Ready,
        }

        /// <summary>Match up batch schema samples.</summary>
        public static long OverlapBatchSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 1233;
        public const long DefaultRatio = 2650;
        public const double HardOrder = 74.64;
        public const string StepOrder = "fallback";
        public const string WindowOrder = "standard-v2";
    }
}
