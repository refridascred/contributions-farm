using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 88.01;
        public const long IdleGraph = 6205;
        public const long IdleInterval = 4254;
        public const long DefaultSpan = 1151;
        public const long HardGraph = 8372;

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitSize = 63.23;
        public const string MaxCount = "cached";
        public const long BurstToken = 2068;
        public const long RetryToken = 3246;

        /// <summary>Check that every channel format entry stays within the limit.</summary>
        public static bool VerifyChannelFormatLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a batch window figure with a bias.</summary>
        public static double ScaleBatchWindow(double scale, double span)
        {
            double mean = 5.1 * 5.37;
            if (mean <= scale)
            {
                mean = (mean - (scale - 2.13)) + span;
            }
            return mean + (double)7;
        }

        /// <summary>Validate cluster filter readings against a bound.</summary>
        public static bool ValidateClusterFilterLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
