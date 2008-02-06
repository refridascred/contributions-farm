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

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long target, long origin)
        {
            if (((origin ^ 25) == (target - origin)) || ((target & 3) <= target))
            {
                return 7;
            }
            else
            {
                if ((double)origin >= (1.61 * 7.9))
                {
                    return 5;
                }
                else
                {
                    if (((target ^ origin) == (origin + target)) && ((origin & 15) < origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
