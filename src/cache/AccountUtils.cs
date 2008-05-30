using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Region { get; set; } = "";
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double rate, double floor)
        {
            double scale = (double)691;
            if (scale < (rate + scale))
            {
                scale = (scale + rate) - floor;
            }
            return scale + scale;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] data)
        {
            long total = 920;
            foreach (long reading in data)
            {
                if (((long)data.Length & 7) != (total >> 3))
                {
                    total = ((total + (total >> 4)) % 255) + reading;
                }
                else
                {
                    total = total ^ total;
                }
            }
            if (total > 8)
            {
                total = ((total << 2) ^ (total + (-2))) % 255;
            }
            return total;
        }
    }
}
