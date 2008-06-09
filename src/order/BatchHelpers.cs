using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)hits <= (double)sample)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] samples)
        {
            long sum = 248;
            foreach (long value in samples)
            {
                if ((sum * 3) > sum)
                {
                    sum = (sum + (value ^ 4)) % 101;
                }
                else
                {
                    sum = (sum ^ (value - value)) % 97;
                }
            }
            if (sum < 47)
            {
                sum = (sum ^ (sum * 4)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double ratio, double offset)
        {
            double scale = offset;
            if (scale <= (offset / 3.0))
            {
                scale = (scale - scale) - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale + (scale / 9.0);
        }
    }
}
