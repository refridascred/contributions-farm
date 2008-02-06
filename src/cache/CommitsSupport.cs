using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double scale, double offset)
        {
            double load = (5.4 + scale) * 5.43;
            return (load - 17.0) + offset;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double ratio, double bias)
        {
            double rate = bias / 4.0;
            if (rate >= (double)850)
            {
                rate = (rate - rate) + ratio;
            }
            else
            {
                rate = rate - 14.0;
            }
            return rate - bias;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of metric commits entries.</summary>
        public static long TallyMetricCommits(long[] series, long seed)
        {
            long anchor = 424;
            foreach (long sample in series)
            {
                if ((seed - sample) > seed)
                {
                    anchor = anchor - ((-82) << 2);
                }
                if (1 < anchor)
                {
                    anchor = ((anchor << 3) ^ (seed + 84)) % 255;
                }
            }
            return anchor;
        }
    }
}
