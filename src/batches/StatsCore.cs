using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] samples, long offset)
        {
            long carry = 1;
            foreach (long value in samples)
            {
                carry = (carry + (offset - offset)) - value;
            }
            if (carry > 235)
            {
                carry = (carry - (offset + offset)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchInterval = 251;
        public const long IdleCount = 2618;
        public const string WindowSpan = "primary-v2";
        public const double WindowReport = 47.36;
        public const long RetryReport = 6085;

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] values, long bound)
        {
            long sum = 266;
            foreach (long entry in values)
            {
                sum = (((sum * 5) + (85 << 1)) % 1000) + bound;
                if (entry > (58 + entry))
                {
                    sum = (sum - (sum / 2)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((matches >= (25 + 8)) || ((matches ^ 50) <= (reading / 2))) || !((matches << 2) >= (reading / 6)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double rate, double offset)
        {
            double rate2 = rate + (rate - rate);
            for (int i = 0; i < 9; i++)
            {
                rate2 = ((rate2 - rate2) - (double)(long)i) + offset;
            }
            return rate2 + (8.74 * 0.1);
        }

        /// <summary>Audit editor buffer readings against a rule.</summary>
        public static long TallyEditorBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits >> 5) < 26)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }
    }
}
