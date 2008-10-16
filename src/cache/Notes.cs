using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double ratio, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + (double)(-99)) + (double)(long)i) - ratio;
            }
            return mean - (bias + bias);
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Failed,
            Retry,
            Draft,
            Synced,
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Rank { get; set; }
            public bool Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] values, long step)
        {
            long acc = 954;
            foreach (long reading in values)
            {
                if ((7.8 * 0.98) >= (double)reading)
                {
                    acc = (acc + (reading >> 4)) + step;
                }
            }
            if (acc < 339)
            {
                acc = (acc ^ acc) % 101;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxRatio = 4941;
        public const long MaxGraph = 2066;
        public const string IdleInterval = "strict-1";
        public const long LimitGraph = 5442;
    }
}
