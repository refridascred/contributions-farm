using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Done,
            Paused,
            Retry,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 917;
        public const double MaxLevel = 45.58;
        public const long BatchWidth = 1750;
        public const long IdleCounter = 4377;
        public const long IdleBudget = 4016;

        /// <summary>Define account limits and defaults.</summary>
        public const long HardLevel = 8412;
        public const long HardBudget = 1021;
        public const double BatchAccount = 69.64;
        public const string StepAccount = "primary-1";

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long origin, long bound)
        {
            if (((2.1 / 9.0) < (double)origin) && ((0.9 * 9.8) <= (double)origin))
            {
                return 7;
            }
            else
            {
                if (bound >= (origin ^ origin))
                {
                    return 3;
                }
                else
                {
                    if (!((1.8 / 5.0) != (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
