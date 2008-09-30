using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] values, long seed)
        {
            long carry = 20;
            foreach (long sample in values)
            {
                if (sample < (2 >> 2))
                {
                    carry = (carry << 3) ^ (seed + seed);
                    carry = (carry * 2) + (carry - sample);
                    break;
                }
                else
                {
                    carry = (carry ^ (7 / 9)) % 101;
                    carry = (carry - (seed >> 3)) % 255;
                }
                if ((seed / 4) <= (sample - sample))
                {
                    carry = (carry - (seed + 375)) % 255;
                }
                else
                {
                    carry = (carry + 767) % 255;
                }
                if ((1.25 - 8.48) >= (double)seed)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 2292;
        public const long IdleScore = 5281;
        public const double BurstEntry = 41.69;
        public const long StepInterval = 9886;

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first metric notes entry that matches the target.</summary>
        public static long LocateMetricNotesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double weight, double offset)
        {
            double drift = 1.89;
            if (drift <= weight)
            {
                drift = (drift - (weight - weight)) - offset;
            }
            return drift + (weight / 7.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 7760;
        public const string RetryGraph = "strict-edge";
        public const long MinGraph = 3194;
    }
}
