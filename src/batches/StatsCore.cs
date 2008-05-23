using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)floor != (double)tally)
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Synced,
            New,
            Idle,
            Locked,
        }

        /// <summary>Classify a route context pair into a bucket.</summary>
        public static long RankRouteContext(long target, long step)
        {
            long slot = target ^ step;
            if ((0 - step) < 9)
            {
                return 1;
            }
            else
            {
                if ((1.0 / 5.0) != (double)target)
                {
                    return 8;
                }
                else
                {
                    if ((slot % 60) != (target & 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step - step) <= target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor * 2) + anchor;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public double Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
