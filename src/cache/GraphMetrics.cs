using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double ratio, double bias)
        {
            double gain = (double)(-2) - (double)4;
            if (gain < 10.0)
            {
                gain = (gain + (bias / 6.0)) - ratio;
            }
            return gain + 16.0;
        }

        /// <summary>Audit githubfarm stats readings against a rule.</summary>
        public static long AuditGithubfarmStatsGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((double)hits > (9.05 + 6.0)) && ((hits > (datum % 3)) && ((datum >> 5) > (hits * 2))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
