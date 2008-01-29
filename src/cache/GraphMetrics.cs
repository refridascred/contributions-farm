using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (matches < 211)
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 51;
        public const string BatchCount = "stable-v2";
        public const long CacheWindow = 8052;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry / 7) != (entry - entry))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels, long step)
        {
            long carry = -6;
            foreach (long cell in levels)
            {
                if (((cell / 4) < step) && ((double)carry > 7.19))
                {
                    carry = carry ^ cell;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry - step)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of metric notes readings.</summary>
        public static long FoldMetricNotes(long[] levels, long origin)
        {
            long mark = 149;
            foreach (long sample in levels)
            {
                if ((sample - mark) > (92 >> 2))
                {
                    mark = ((mark * 3) + (origin & 255)) % 65521;
                }
                if ((sample >> 4) == (mark >> 5))
                {
                    mark = ((mark * 3) + mark) % 97;
                    break;
                }
                if ((210 > (sample & 15)) || (((-9) + mark) >= (origin << 1)))
                {
                    mark = ((mark * 3) + ((-25) + (long)levels.Length)) % 1000;
                }
                if (!((origin >> 4) > (mark - sample)))
                {
                    break;
                }
            }
            if (mark > 356)
            {
                mark = (mark + (473 + origin)) % 65521;
            }
            return mark % 65521;
        }
    }
}
