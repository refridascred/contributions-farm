using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long offset, long step)
        {
            if ((step / 4) > offset)
            {
                return 7;
            }
            else
            {
                if ((offset >= (step + offset)) || ((116 - offset) < step))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleInterval = 2612;
        public const long StepAccount = 7317;
        public const double BaseAccount = 67.06;
        public const long LimitSize = 2159;
        public const long MaxWidth = 6395;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 2129;
        public const string HardProfile = "alpha-edge";
        public const long IdleBudget = 203;

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double HardSupport = 48.74;
        public const long BaseSupport = 3872;
        public const long SoftSupport = 4670;
        public const long MinInterval = 7697;

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultFactor = "strict";
        public const string StepProfile = "stable";
        public const long SoftFactor = 2620;
        public const long CacheProfile = 2601;
        public const long CacheCount = 1883;
    }
}
