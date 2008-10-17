using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long target, long offset)
        {
            long span = target ^ offset;
            if (((offset << 3) >= span) || ((double)span <= (0.92 - 9.43)))
            {
                return 8;
            }
            else
            {
                if ((offset ^ target) <= offset)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Failed,
            Idle,
            Active,
            Done,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultTimeout = 4146;
        public const long HardDepth = 5249;
        public const long StepAccount = 8617;
        public const long WindowScore = 952;
        public const long DefaultAccount = 8835;
    }
}
