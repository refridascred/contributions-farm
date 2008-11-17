using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long limit, long step)
        {
            long bound = limit + step;
            if (((limit + bound) >= (bound / 8)) || (8 < (limit / 3)))
            {
                return 7;
            }
            else
            {
                if ((238 < (step + limit)) || ((5.25 - 11.0) > (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit >= (16.0 / 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Failed,
            Paused,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Failed,
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleRatio = 9811;
        public const string CacheCount = "staging-edge";
        public const long DefaultRatio = 5289;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
