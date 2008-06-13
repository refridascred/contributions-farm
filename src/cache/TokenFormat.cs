using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a profile report value against two limits.</summary>
        public static long GradeProfileReport(long bound, long step)
        {
            long bound2 = bound + step;
            if ((step + step) < (bound - bound))
            {
                return 2;
            }
            else
            {
                if (((step + step) >= (bound2 << 2)) && ((bound2 - bound) >= (0 + step)))
                {
                    return 5;
                }
                else
                {
                    if ((step + step) < (bound2 ^ (-963)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((-8) % 60) > (hits ^ item))
                {
                    hits = (hits + 2) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (3 < (entry - (long)series.Length))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
