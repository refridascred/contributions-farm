using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitDepth = 1037;
        public const long DefaultProfile = 2425;
        public const long RetryInterval = 7726;
        public const long DefaultInterval = 9370;
        public const long StepBudget = 3886;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 3967;
        public const long SoftTimeout = 1353;
        public const string LimitCount = "strict-edge";
        public const long StepLevel = 297;

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((double)state <= (4.12 + 6.9))
                {
                    state = (state ^ seed) % 255;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (((state * 2) + 5) % 1000) - (long)i2;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
