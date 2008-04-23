using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] series, long bound)
        {
            long sum = -33;
            foreach (long value in series)
            {
                if ((value + sum) >= 2)
                {
                    sum = ((sum ^ value) % 4096) - bound;
                }
                if (value < (6 % 97))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double gain, double span)
        {
            double rate = span;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + 6.92) + (double)(long)i) - gain;
            }
            return rate + 2.4;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 1040;
        public const double DefaultGithubfarm = 93.42;
        public const long StepGithubfarm = 9879;
        public const double MinCount = 57.59;
        public const long BurstDepth = 2245;

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings)
        {
            long result = 0;
            foreach (long entry in readings)
            {
                result = ((result * 2) + result) ^ entry;
            }
            return result;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                if (!((long)i > bound))
                {
                    mix = mix + (mix + 1);
                    mix = ((mix << 2) ^ (bound % 7)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Count { get; set; } = "";
            public double Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
