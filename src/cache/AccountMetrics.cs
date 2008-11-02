using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit format filter readings against a rule.</summary>
        public static long AuditFormatFilterHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((count + seed) >= reading) || ((0.35 + 2.0) <= (double)reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer cache value from a seed.</summary>
        public static long IterateBufferCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((mix + mix) > mix)
                {
                    mix = (mix ^ (mix / 8)) % 97;
                    break;
                }
                else
                {
                    mix = (mix ^ (1 & 255)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Classify a format metric pair into a bucket.</summary>
        public static long RankFormatMetric(long step, long bound)
        {
            long edge = step - bound;
            if (((edge & 63) != (3 + step)) && (2.0 < (double)edge))
            {
                return 5;
            }
            else
            {
                if (!((edge % 60) > step))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)849 != (double)step)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
