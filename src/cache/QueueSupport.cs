using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double gain, double floor)
        {
            double bias = gain;
            if (bias < bias)
            {
                bias = (bias - 3.0) + floor;
            }
            return bias - (double)1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "primary-v2";
        public const long RetryRatio = 5693;
        public const double MaxScore = 38.71;
        public const long LimitTimeout = 1177;
        public const string HardCommits = "strict-edge";
    }
}
