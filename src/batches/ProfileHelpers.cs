using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long floor, long seed)
        {
            long offset = floor ^ seed;
            if ((seed >= 34) && ((5.88 + 8.69) < (double)offset))
            {
                return 4;
            }
            else
            {
                if ((5.1 + 2.39) >= (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit counter route readings against a rule.</summary>
        public static long AuditCounterRouteOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally > (5.7 / 6.0))
                {
                    tally = ((tally + 2) ^ reading) - target;
                }
            }
            return tally;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] samples, long step)
        {
            long sum = 5;
            foreach (long sample in samples)
            {
                if (sample > (sample / 2))
                {
                    sum = (sum << 3) ^ (step % 3);
                }
            }
            return sum;
        }

        /// <summary>Measure how many tools graph samples are out of range.</summary>
        public static long MeasureToolsGraphOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry * 4) <= (entry * 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 7758;
        public const long RetryCache = 3425;
        public const long HardRatio = 6519;
        public const long WindowCache = 6747;
        public const double DefaultScore = 97.29;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long origin, long offset)
        {
            if (origin >= offset)
            {
                return 3;
            }
            else
            {
                if ((origin >= (origin & 255)) && (offset <= origin))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
