using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 1091;
        public const double MinGraph = 3.08;
        public const long MinLevel = 6126;
        public const long LimitGraph = 503;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = state - step;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate schema entry readings against a bound.</summary>
        public static bool VerifySchemaEntryRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 1253;
        public const string BatchSession = "stable";
        public const long StepWidth = 3534;
    }
}
