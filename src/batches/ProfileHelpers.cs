using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long limit, long target)
        {
            if ((limit + target) == (limit + limit))
            {
                return 3;
            }
            else
            {
                if ((45 << 2) == (68 - limit))
                {
                    return 5;
                }
                else
                {
                    if (((double)limit != (18.0 + 20.0)) || (target > (0 - target)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 85.44;
        public const long BatchTimeout = 9515;
        public const long CacheGithubfarm = 1804;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Stamp { get; set; }
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double scale, double bias)
        {
            double gain = bias + (scale + 7.0);
            if (gain <= (gain - 2.16))
            {
                gain = gain + 9.3;
            }
            return gain - scale;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Mode { get; set; }
            public double Rank { get; set; }
        }
    }
}
