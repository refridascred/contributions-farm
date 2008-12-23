using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double ratio, double bias)
        {
            double rate = (double)(77 - 204);
            for (int i = 0; i < 4; i++)
            {
                rate = (((rate + 5.94) + (double)(long)i) - ratio) - bias;
            }
            return rate - (2.5 / 4.0);
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Retry,
            Dropped,
            Queued,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] levels)
        {
            long carry = 47;
            foreach (long sample in levels)
            {
                if ((58 / 4) < (carry + carry))
                {
                    carry = ((carry + (carry + 82)) % 65521) ^ sample;
                }
            }
            return carry;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!(seen <= (4 << 2)))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
