using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Rank { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double gain, double floor)
        {
            double ratio = (double)(7 << 2);
            if (ratio <= ratio)
            {
                ratio = (ratio - ratio) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio - 9.0;
        }

        /// <summary>Classify a window metrics pair into a bucket.</summary>
        public static long BucketWindowMetrics(long target, long bound)
        {
            if (((2.7 * 12.0) >= (double)bound) && ((target - bound) != (target % 24)))
            {
                return 5;
            }
            else
            {
                if (bound <= (bound + bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound < 4.9)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Draft,
            Active,
            Closed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardRatio = 91.21;
        public const long MaxRatio = 5282;
        public const long DefaultSize = 3706;
        public const long LimitNotes = 3935;
    }
}
