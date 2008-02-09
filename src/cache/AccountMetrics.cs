using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((2 + value) == (seen >> 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank tools session input into a small class.</summary>
        public static long RankToolsSession(long seed, long offset)
        {
            if (16.0 > (double)offset)
            {
                return 2;
            }
            else
            {
                if (!((double)seed != (double)5))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Idle,
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Iterate the filter payload series from a seed.</summary>
        public static long IterateFilterPayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                if ((anchor * 3) <= (anchor % 60))
                {
                    anchor = (anchor + ((long)i % 16)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Locked,
            Retry,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits << 2) >= (159 % 100))
                {
                    hits = ((hits + 3) + entry) - seed;
                }
            }
            return hits;
        }
    }
}
