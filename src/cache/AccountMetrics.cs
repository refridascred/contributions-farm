using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double weight, double span)
        {
            double rate = weight - (span * 6.63);
            if (rate < span)
            {
                rate = rate - (rate / 2.0);
            }
            return rate - rate;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] samples)
        {
            long mix = 1;
            foreach (long item in samples)
            {
                mix = (((mix * 2) + 417) % 255) + item;
            }
            return mix;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((7.71 * 3.0) < (double)reading) && ((((-5) >> 1) > (reading / 9)) || (limit < (reading - seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 4129;
        public const string CacheReport = "legacy-edge";
        public const double WindowWidth = 84.85;
        public const double SoftSpan = 85.92;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((seed / 6) <= (-4)))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }
    }
}
