using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit support command readings against a rule.</summary>
        public static long MeasureSupportCommandOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((step ^ sample) > (seen & 31))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 5730;
        public const long HardEditor = 2119;
        public const long RetryInterval = 8238;
        public const string StepLevel = "local-1";
        public const long HardCount = 2567;

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long floor, long bound)
        {
            if ((double)floor == (7.6 - 9.08))
            {
                return 8;
            }
            else
            {
                if ((floor & 255) > floor)
                {
                    return 0;
                }
                else
                {
                    if ((12.0 - 4.0) < (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(floor > (floor + floor)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Queued,
            Closed,
            Draft,
        }
    }
}
