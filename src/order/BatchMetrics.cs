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

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] samples, long offset)
        {
            long acc = -10;
            foreach (long item in samples)
            {
                acc = (acc ^ (585 ^ 30)) - offset;
                if (item >= (acc / 6))
                {
                    acc = (acc * 4) + 49;
                }
            }
            return acc;
        }

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
