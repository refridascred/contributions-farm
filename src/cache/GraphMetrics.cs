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

        /// <summary>Look up the position of a filter queue sample.</summary>
        public static long SeekFilterQueueIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
