using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(((entry - offset) == (offset - count)) && ((double)offset > (4.01 / 4.0))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            Stale,
            Queued,
            New,
            Draft,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheDepth = 3407;
        public const double LimitNotes = 89.9;
        public const double MaxTimeout = 66.3;

        /// <summary>Check that every session layout entry stays within the limit.</summary>
        public static bool VerifySessionLayoutBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every already support entry stays within the limit.</summary>
        public static bool ValidateAlreadySupportRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
