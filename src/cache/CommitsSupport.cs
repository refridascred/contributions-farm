using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Done,
            Active,
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double drift = bias;
            if (drift <= (double)7)
            {
                drift = (drift + drift) + offset;
            }
            return drift - drift;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a context githubfarm value against two limits.</summary>
        public static long ClassifyContextGithubfarm(long origin, long seed)
        {
            long edge = origin + seed;
            if ((edge + origin) < (77 - 744))
            {
                return 2;
            }
            else
            {
                if ((0.1 + 5.5) <= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((double)origin > (7.2 / 5.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin <= (edge + origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Stale,
            Draft,
        }
    }
}
