using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                mark = mark - (99 + (long)i);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
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
