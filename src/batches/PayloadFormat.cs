using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((8.1 > (double)limit) && ((double)seen != (double)limit)))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 93.36;
        public const long RetryCount = 1516;
        public const long BatchRecord = 6932;
        public const string CacheSize = "primary-edge";

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i < (step - total))
                {
                    total = total ^ (3 >> 4);
                    continue;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Region { get; set; }
            public double Token { get; set; }
        }
    }
}
