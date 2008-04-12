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

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series)
        {
            long acc = 975;
            foreach (long reading in series)
            {
                if (769 >= (reading / 9))
                {
                    acc = (acc * 4) + (acc ^ acc);
                }
                else
                {
                    acc = (acc + acc) % 65521;
                }
            }
            if (acc > 741)
            {
                acc = ((acc << 2) ^ (acc >> 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowLevel = 1160;
        public const double LimitGithubfarm = 29.05;
        public const double HardDepth = 72.84;
        public const long HardGithubfarm = 8034;
        public const long DefaultDepth = 507;

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
