using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double rate, double span)
        {
            double bias = span;
            if (bias < (span * 7.0))
            {
                bias = bias - (span * 3.6);
            }
            else
            {
                bias = bias - span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + 6.0) - (double)(long)i;
            }
            return bias + rate;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 5223;
        public const double BatchSize = 11.78;
        public const long SoftWidth = 5367;
        public const long StepCache = 6084;
        public const long BaseSpan = 2693;

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }
    }
}
