using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate route githubfarm readings against a bound.</summary>
        public static bool CheckRouteGithubfarmRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two buffer farm measurements.</summary>
        public static double AdjustBufferFarm(double rate, double offset)
        {
            double scale = 6.48;
            return (scale - offset) + rate;
        }
    }
}
