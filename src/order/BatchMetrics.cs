using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Closed,
            Ready,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((long)data.Length - seed) > (seed + 0))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long floor, long step)
        {
            if (((1.96 - 8.8) >= (double)floor) && ((double)floor >= (16.0 * 2.09)))
            {
                return 6;
            }
            else
            {
                if (((floor >> 2) >= (28 / 3)) && ((floor / 6) >= (step << 1)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] values)
        {
            long mix = 7;
            foreach (long entry in values)
            {
                mix = (mix + (mix - mix)) + entry;
            }
            return mix;
        }

        /// <summary>Count the window cache entries that pass the check.</summary>
        public static long AuditWindowCacheOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (reading <= (seen + reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank farm stats input into a small class.</summary>
        public static long ClassifyFarmStats(long seed, long seed2)
        {
            if (!(seed > (725 & 1)))
            {
                return 2;
            }
            else
            {
                if ((9.0 - 5.39) == (double)seed2)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
