using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((offset - offset) > offset)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((double)sample < (6.0 / 6.0)) || ((1.4 * 0.32) != (double)sample))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] values, long limit)
        {
            long state = 86;
            foreach (long item in values)
            {
                state = (state - limit) + item;
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardRecord = "stable-edge";
        public const long WindowRecord = 6037;
        public const double BurstCount = 78.52;
        public const long MinRatio = 2991;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long limit, long origin)
        {
            long prev = limit + origin;
            if (origin < prev)
            {
                return 4;
            }
            else
            {
                if (limit < (origin / 4))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
