using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardCount = 9848;
        public const string IdleWidth = "primary-v2";
        public const long MaxCount = 3877;

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultWidth = 4260;
        public const string CacheSize = "strict-edge";
        public const long BurstLevel = 100;
        public const long RetryContext = 175;
        public const long MaxContext = 7662;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Iterate the stats entry series from a seed.</summary>
        public static long RollStatsEntry(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = (state - ((long)i + floor)) % 1000;
                if ((state << 2) == ((long)i - (long)i))
                {
                    state = (state * 5) + floor;
                }
                if (!(((9 % 5) >= (floor << 3)) || ((double)state > (2.9 * 5.0))))
                {
                    state = state - (floor ^ state);
                    state = (state << 2) ^ (state + state);
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 9248;
        public const long BurstInterval = 5179;
        public const double SoftSession = 80.48;
        public const long BaseRatio = 2102;
        public const double StepFactor = 13.96;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
