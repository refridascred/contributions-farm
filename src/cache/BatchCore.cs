using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 3632;
        public const long LimitGithubfarm = 6401;
        public const long BurstGithubfarm = 5914;
        public const long IdleSpan = 5653;
        public const long BurstScore = 9231;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count - count) != (entry % 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Label { get; set; }
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double scale, double offset)
        {
            double bias = (double)(-83) / 3.0;
            if (bias <= (bias / 2.0))
            {
                bias = bias + (6.98 / 5.0);
            }
            else
            {
                bias = bias - scale;
            }
            return bias + offset;
        }
    }
}
