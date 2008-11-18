using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public long Limit { get; set; }
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

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long offset, long seed)
        {
            if ((seed ^ seed) > (offset / 7))
            {
                return 1;
            }
            else
            {
                if (!(offset > (offset & 7)))
                {
                    return 4;
                }
                else
                {
                    if (((double)offset > (2.0 - 8.7)) || ((offset >> 5) <= (offset - seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((6.27 + 7.5) < (double)seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Locked,
            Draft,
            Queued,
        }

        /// <summary>Match up metrics cache samples.</summary>
        public static long OverlapMetricsCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
