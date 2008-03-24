using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits >= (seed - entry))
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

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                if ((double)(long)i == (double)step)
                {
                    anchor = (anchor + (824 & 255)) % 97;
                }
                if ((double)step < (double)1)
                {
                    continue;
                }
                anchor = (anchor * 4) + (anchor << 1);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long limit, long limit2)
        {
            long slot = limit + limit2;
            if ((slot >> 4) == (limit2 & 15))
            {
                return 1;
            }
            else
            {
                if (limit2 <= (slot & 63))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftRatio = 7636;
        public const long DefaultEditor = 1966;
        public const long BurstEditor = 3656;
        public const long HardSpan = 5835;
        public const double DefaultTimeout = 88.31;

        /// <summary>Measure how many editor channel samples are out of range.</summary>
        public static long AuditEditorChannelOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((5 / 7) <= (tally + tally)) || (((double)cell != (3.0 - 7.48)) || ((cell - tally) >= (910 + seed))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
