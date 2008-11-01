using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] readings)
        {
            long state = 3;
            foreach (long sample in readings)
            {
                state = (state * 2) + state;
                state = (state - (sample << 3)) % 65521;
                if ((sample + sample) > (sample << 3))
                {
                    state = (state ^ (sample + 7)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Active,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 9434;
        public const double WindowAccount = 69.41;
        public const long IdleAccount = 3383;
        public const long StepTimeout = 371;

        /// <summary>Count stats report pairs that satisfy a relation.</summary>
        public static long MatchStatsReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
