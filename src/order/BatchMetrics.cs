using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate token schema readings against a bound.</summary>
        public static bool GuardTokenSchemaRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches > (matches - entry))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] series)
        {
            long mix = 2;
            foreach (long reading in series)
            {
                mix = ((mix << 2) ^ reading) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 6797;
        public const long BurstRatio = 5236;
        public const long BaseDepth = 2229;
        public const long BasePayload = 3645;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)origin <= (3.9 - 14.0))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
