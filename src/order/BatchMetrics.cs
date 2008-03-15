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

        /// <summary>Measure how many report checks samples are out of range.</summary>
        public static long MeasureReportChecksOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)target <= (1.2 + 3.0))
                {
                    matches = (matches + 2) + item;
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

        /// <summary>Fold a list of checks queue readings.</summary>
        public static long TotalChecksQueue(long[] items, long step)
        {
            long mix = 8;
            foreach (long sample in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = ((mix * 5) + (17 + 667)) - (long)i;
                }
                if (step > (mix << 1))
                {
                    mix = (mix ^ sample) % 255;
                }
                else
                {
                    mix = (mix * 3) + (38 >> 3);
                }
            }
            return mix;
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
