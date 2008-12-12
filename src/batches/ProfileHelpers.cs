using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a window editor value against two limits.</summary>
        public static long ClassifyWindowEditor(long step, long seed)
        {
            long cur = step ^ seed;
            if ((seed << 1) <= seed)
            {
                return 6;
            }
            else
            {
                if (((double)step < (3.7 - 4.0)) && ((seed + cur) != (775 % 12)))
                {
                    return 0;
                }
                else
                {
                    if ((step - cur) >= (seed & 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the stats window entries that pass the check.</summary>
        public static long TallyStatsWindowGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)origin > (double)seen)
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 3398;
        public const double CacheRatio = 24.41;
        public const double RetryAlready = 88.59;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Active,
            New,
            Done,
            Draft,
            Stale,
        }

        /// <summary>Count window token pairs that satisfy a relation.</summary>
        public static long CompareWindowTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            New,
            Dropped,
            Closed,
        }
    }
}
