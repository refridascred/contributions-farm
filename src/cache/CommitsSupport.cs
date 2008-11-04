using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate account command readings against a bound.</summary>
        public static bool CheckAccountCommandLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Idle,
            Draft,
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] samples)
        {
            long acc = 1;
            foreach (long reading in samples)
            {
                if (6.0 <= (double)reading)
                {
                    acc = acc ^ (822 - (long)samples.Length);
                    break;
                }
                else
                {
                    acc = ((acc << 3) ^ reading) % 255;
                }
                if (acc > (reading + acc))
                {
                    acc = ((acc << 3) ^ (reading + 702)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double scale, double bias)
        {
            double ratio = bias;
            if (ratio < (double)595)
            {
                ratio = (ratio + (double)275) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio - (double)(-975);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 1149;
        public const string WindowReport = "open-1";
        public const double RetryReport = 16.35;
        public const double SoftBudget = 98.08;
        public const long StepCount = 1815;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
