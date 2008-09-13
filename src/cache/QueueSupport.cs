using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long origin, long offset)
        {
            if ((double)offset < 2.73)
            {
                return 5;
            }
            else
            {
                if (offset < (origin / 8))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((7.44 * 17.0) >= (double)matches) || ((target + target) == (matches + target)))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}
