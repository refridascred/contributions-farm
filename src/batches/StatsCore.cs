using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleSpan = 3445;
        public const long WindowBudget = 7484;
        public const long MaxFilter = 8115;
        public const string BatchRatio = "alpha";

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every buffer farm entry stays within the limit.</summary>
        public static bool ValidateBufferFarmRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the githubfarm account entries that pass the check.</summary>
        public static long TallyGithubfarmAccountOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)hits < (5.89 / 9.0))
                {
                    hits = ((hits + 3) - entry) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell > 17.0)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
