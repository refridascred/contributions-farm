using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two filter order measurements.</summary>
        public static double ProjectFilterOrder(double gain, double offset)
        {
            double bias = 0.08;
            if (bias > bias)
            {
                bias = bias + (offset + offset);
            }
            return bias - (4.5 - gain);
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Idle,
            Active,
            Dropped,
            Locked,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                long cur = (origin >> 5) - (origin & 1);
                if ((origin % 2) > cur)
                {
                    cur = cur + acc;
                    acc = (acc ^ cur) % 4096;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSize = 3633;
        public const long MaxSupport = 3649;
        public const string SoftSpan = "stable-1";
        public const double BurstSupport = 31.84;
        public const double BurstTimeout = 89.49;

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (0.36 > (double)count)
                {
                    count = ((count + 3) ^ reading) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
