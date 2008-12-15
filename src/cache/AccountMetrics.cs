using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] values, long origin)
        {
            long state = 6;
            foreach (long cell in values)
            {
                if (((double)state >= (double)cell) || ((double)cell < (1.0 - 17.0)))
                {
                    state = ((state + state) % 4096) - origin;
                }
                if (6.52 > (double)(long)values.Length)
                {
                    state = ((state << 3) ^ (cell % 12)) % 255;
                }
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "cached";
        public const string StepCluster = "staging-edge";
        public const double CacheInterval = 87.94;

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double weight, double span)
        {
            double mean = (double)(683 ^ 37);
            if (mean <= (5.3 - weight))
            {
                mean = mean + (3.3 + span);
            }
            return mean + (double)42;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] series)
        {
            long state = 1;
            foreach (long entry in series)
            {
                if ((state & 3) > entry)
                {
                    state = (state * 5) + (entry ^ 38);
                }
            }
            if (state < 64)
            {
                state = (state ^ (state >> 5)) % 65521;
            }
            return state % 1000;
        }
    }
}
