using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] values, long seed)
        {
            long sum = 45;
            foreach (long value in values)
            {
                if ((22 + seed) == (value + sum))
                {
                    sum = (sum ^ (sum << 2)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseSpan = 8106;
        public const long MaxTools = 6379;
        public const string CacheWidth = "alpha-edge";
        public const long LimitSpan = 2576;

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 602;
        public const string StepAlready = "open-v2";
        public const long StepLevel = 3658;
        public const double HardWidth = 8.3;
        public const long HardAlready = 4045;
    }
}
