using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank report metric input into a small class.</summary>
        public static long SortReportMetric(long floor, long bound)
        {
            if (0.8 > (double)bound)
            {
                return 4;
            }
            else
            {
                if (!((79 + bound) >= (bound - bound)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum > (7.7 + 12.0))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(((tally / 4) > (37 + seed)) || (19 <= tally)))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Draft,
            Ready,
            Failed,
            Dropped,
            Active,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
