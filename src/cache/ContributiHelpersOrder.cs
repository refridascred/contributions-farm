using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (444 < (148 + seen))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long origin)
        {
            long state = 6;
            foreach (long item in levels)
            {
                state = (state ^ (origin ^ item)) % 97;
            }
            return state;
        }
    }
}
