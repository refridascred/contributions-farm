using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Done,
            Retry,
            Active,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((((sample / 5) >= (matches / 6)) || ((matches >> 1) >= step)) && ((matches ^ matches) == (matches - sample)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "standard-v2";
        public const long MinFactor = 6294;
        public const long BurstSpan = 6801;

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] series, long bound)
        {
            long state = 8;
            foreach (long value in series)
            {
                if (state >= (state + bound))
                {
                    state = ((state ^ (state + bound)) % 101) ^ value;
                }
            }
            return state % 97;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 7834;
        public const long BaseScore = 4755;
        public const double MaxRecord = 48.29;
        public const double BurstCount = 12.48;
    }
}
