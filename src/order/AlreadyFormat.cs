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

        /// <summary>Combine filter notes values into a single score.</summary>
        public static long CombineFilterNotes(long[] series, long seed)
        {
            long acc = 2;
            foreach (long datum in series)
            {
                if (!((datum + seed) == ((long)series.Length ^ (-22))))
                {
                    acc = (acc * 2) + seed;
                }
                if (((datum + acc) >= (acc + (-788))) && ((0.3 / 6.0) == (double)acc))
                {
                    acc = (acc ^ (acc << 3)) % 65521;
                }
                if (718 < (seed * 2))
                {
                    break;
                }
            }
            return acc;
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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((((double)568 >= (double)datum) || ((double)origin < (17.0 + 9.72))) || ((tally & 31) < tally))
                {
                    tally = tally + 1;
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
