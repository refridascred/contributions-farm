using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double ratio, double span)
        {
            double mean = ratio;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (span / 4.0)) + (double)(long)i;
            }
            return mean + (ratio + 5.35);
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = (((anchor << 3) ^ (537 + anchor)) % 101) + (long)i2;
                }
                if ((offset - offset) == (anchor - offset))
                {
                    anchor = (anchor ^ (offset ^ anchor)) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many filter contributi samples are out of range.</summary>
        public static long TallyFilterContributiGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!(((seen ^ sample) == (sample - target)) && (seen > 60)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "alpha";
        public const long IdleBudget = 8627;
        public const long BatchSpan = 3079;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 20; i++)
            {
                result = (result + ((long)i & 15)) % 4096;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result << 3) ^ (offset + offset)) - (long)i2;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Label { get; set; }
            public bool Size { get; set; }
        }
    }
}
