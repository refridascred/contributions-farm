using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultWidth = 4260;
        public const string CacheSize = "strict-edge";
        public const long BurstLevel = 100;
        public const long RetryContext = 175;
        public const long MaxContext = 7662;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Count { get; set; }
            public long Score { get; set; }
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

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "local-edge";
        public const double HardBudget = 46.54;
        public const long IdleCount = 7935;

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
