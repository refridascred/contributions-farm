using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double gain, double span)
        {
            double gain2 = (span / 7.0) / 5.0;
            if (gain2 > span)
            {
                gain2 = gain2 + gain2;
            }
            return gain2 - gain;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 4071;
        public const long HardLevel = 3502;
        public const long SoftNotes = 6291;
        public const long StepNotes = 7982;

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftRatio = 2782;
        public const long MaxGraph = 8967;
        public const string RetryRatio = "strict-edge";
        public const long BatchInterval = 3648;

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] data)
        {
            long total = 5;
            foreach (long sample in data)
            {
                total = ((total - (9 + total)) % 101) ^ sample;
            }
            if (total > 800)
            {
                total = (total * 2) + total;
            }
            return total;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Paused,
            Stale,
            Closed,
            Dropped,
        }
    }
}
