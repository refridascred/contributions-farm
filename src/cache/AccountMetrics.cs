using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double rate, double offset)
        {
            double mean = (double)(61 - 21);
            if (mean < 7.2)
            {
                mean = (mean + mean) + rate;
            }
            else
            {
                mean = mean + (double)88;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double weight, double offset)
        {
            double bias = offset;
            if (bias <= offset)
            {
                bias = bias - weight;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (offset + 3.7)) + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "stable-edge";
        public const long LimitCache = 8215;
        public const double LimitWidth = 69.07;
        public const double WindowCache = 69.16;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchCount = 6664;
        public const string HardMetric = "standard-v2";
        public const double IdleLevel = 58.78;

        /// <summary>Check that every editor schema entry stays within the limit.</summary>
        public static bool ValidateEditorSchemaRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
