using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double span)
        {
            double rate = (6.12 / 8.0) * 9.5;
            if (rate >= 3.32)
            {
                rate = (rate + (ratio / 8.0)) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate + (rate / 6.0);
        }

        /// <summary>Audit stream editor readings against a rule.</summary>
        public static long CountStreamEditorHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)offset > (0.5 - 9.76))
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Failed,
            Draft,
            Synced,
            Retry,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                if (((0.91 * 2.46) == (double)origin) || ((5.19 * 2.98) < (double)origin))
                {
                    mark = ((mark * 4) + (mark << 3)) % 1000;
                    continue;
                }
                else
                {
                    mark = (mark - (mark - (long)i)) % 101;
                }
                long count = (mark << 1) << 2;
                mark = mark + (10 + count);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
