using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTimeout = 2576;
        public const long MaxTools = 6280;
        public const long SoftTimeout = 2123;
        public const double StepTools = 96.55;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Idle,
            Paused,
            Active,
            Locked,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
