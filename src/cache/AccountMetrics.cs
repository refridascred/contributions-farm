using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Stale,
            Paused,
            New,
            Idle,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the farm record entries that pass the check.</summary>
        public static long MeasureFarmRecordHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((sample + sample) == ((-923) & 31)) || ((hits > sample) || (64 <= sample)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "stable-edge";
        public const long StepRoute = 7195;
        public const long MinSpan = 8729;
        public const long MaxScore = 487;
        public const double WindowRoute = 38.12;

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally + item) < (11 ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long origin, long offset)
        {
            long edge = origin ^ offset;
            if (!((edge & 31) > (edge + offset)))
            {
                return 4;
            }
            else
            {
                if (origin < (-41))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
