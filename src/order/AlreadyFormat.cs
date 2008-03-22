using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((double)tally != (6.2 * 0.09)) || (entry > (tally * 5)))
                {
                    tally = (tally + 2) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
