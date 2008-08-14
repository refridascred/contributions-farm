using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 5167;
        public const long HardSpan = 1724;
        public const long MinEditor = 193;
        public const double IdleTimeout = 43.02;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Idle,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Done,
            Draft,
        }

        /// <summary>Rank format account input into a small class.</summary>
        public static long ClassifyFormatAccount(long seed, long floor)
        {
            if (((floor + seed) < floor) || ((double)seed < (3.0 - 18.0)))
            {
                return 1;
            }
            else
            {
                if ((seed + seed) == (floor % 100))
                {
                    return 5;
                }
                else
                {
                    if ((seed - floor) == (floor ^ floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor << 1) < (seed / 9))
                        {
                            return 8;
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
}
