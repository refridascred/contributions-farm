using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of route layout readings.</summary>
        public static long CombineRouteLayout(long[] values)
        {
            long mix = 2;
            foreach (long reading in values)
            {
                mix = (((mix << 3) ^ (mix & 63)) % 65521) - reading;
            }
            return mix % 97;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)seen < (2.1 + 8.0))
                {
                    seen = ((seen + 1) ^ value) + origin;
                }
            }
            return seen;
        }

        /// <summary>Project the next window metric value.</summary>
        public static double BlendWindowMetric(double rate, double offset)
        {
            double rate2 = (double)294 + rate;
            return (rate2 - (rate / 5.0)) + offset;
        }

        /// <summary>Check that every stream batch entry stays within the limit.</summary>
        public static bool VerifyStreamBatchRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits >= (663 & 1))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
