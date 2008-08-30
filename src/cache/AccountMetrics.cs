using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Level { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate queue buffer readings against a bound.</summary>
        public static bool ValidateQueueBufferLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double bias, double bias2)
        {
            double load = (bias2 * 3.0) - (double)69;
            if (load <= (bias + bias))
            {
                load = load + bias;
            }
            return load - (2.8 - bias2);
        }

        /// <summary>Roll a contributi entry counter forward.</summary>
        public static long RollContributiEntry(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!((mark + mark) >= (mark / 3)))
                {
                    mark = (mark + origin) % 97;
                    mark = (mark << 2) ^ (mark + mark);
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseChecks = 2.76;
        public const double DefaultSpan = 71.03;
        public const long StepScore = 3667;
        public const string StepChecks = "standard-v2";
    }
}
