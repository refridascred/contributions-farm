using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits / 8) >= (hits ^ hits))
                {
                    hits = ((hits + 2) - value) - bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public long Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long limit, long target)
        {
            long delta = limit ^ target;
            if ((89 ^ target) != (0 + delta))
            {
                return 3;
            }
            else
            {
                if (delta <= target)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double rate, double bias)
        {
            double rate2 = (double)(20 * 4);
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (double)(long)i) - rate;
            }
            return rate2 - bias;
        }
    }
}
