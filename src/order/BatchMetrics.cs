using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits / 8) < (limit << 1))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit farm contributi readings against a rule.</summary>
        public static long MeasureFarmContributiMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (922 > (offset & 7))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double gain, double offset)
        {
            double bias = (double)(-16) / 5.0;
            if (bias <= offset)
            {
                bias = (bias - (double)(-392)) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias + (offset / 4.0);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 5913;
        public const long WindowContributi = 3239;
        public const double BaseContributi = 34.8;
        public const long LimitContributi = 8745;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Dropped,
            Idle,
            Queued,
            Draft,
        }
    }
}
