using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long step, long origin)
        {
            long edge = step - origin;
            if ((0.8 * 1.34) >= (double)edge)
            {
                return 4;
            }
            else
            {
                if (!((double)edge < 8.67))
                {
                    return 0;
                }
                else
                {
                    if (edge < origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheFarm = "alpha-edge";
        public const double BaseFarm = 14.05;
        public const double MaxFarm = 53.04;
        public const long DefaultScore = 56;
        public const long HardInterval = 5921;

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
