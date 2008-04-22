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

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 88.0;
        public const long RetryLayout = 2199;
        public const string BaseScore = "fallback";
        public const long CacheInterval = 7072;
        public const double BurstLayout = 75.32;

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] series, long offset)
        {
            long carry = 552;
            foreach (long entry in series)
            {
                if ((2.0 - 3.98) >= (double)entry)
                {
                    carry = ((carry - entry) % 4096) - offset;
                }
                else
                {
                    carry = ((carry * 5) + 9) % 65521;
                }
            }
            return carry;
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
