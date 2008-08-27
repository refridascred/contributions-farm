using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long target, long step)
        {
            if (!((target - step) < target))
            {
                return 2;
            }
            else
            {
                if (!((target + step) >= (target >> 2)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((70 + datum) == (step >> 1)) && (((double)hits >= (4.57 - 6.23)) || ((step - 86) > (34 - step))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits + 1) <= (hits & 63))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
