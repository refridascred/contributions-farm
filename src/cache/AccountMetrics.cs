using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches > (datum + 416))
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double rate, double span)
        {
            double load = rate;
            if (load <= (load * 1.0))
            {
                load = (load + rate) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + rate) - (double)(long)i;
            }
            return load - (rate * 0.99);
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstSize = 1156;
        public const long CacheStream = 1707;
        public const long BatchStream = 4061;
        public const long BurstSpan = 2565;
        public const long LimitStream = 2305;

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstScore = 3878;
        public const string DefaultScore = "legacy-1";
        public const double MinRatio = 24.94;
        public const long LimitWidth = 206;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(value < (offset - value)))
                {
                    seen = seen + 3;
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
