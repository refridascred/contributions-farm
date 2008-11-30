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

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits ^ floor) == (34 & 3))
                {
                    hits = (hits + 2) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
