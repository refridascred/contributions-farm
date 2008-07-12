using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate schema githubfarm samples.</summary>
        public static long TotalSchemaGithubfarm(long[] samples, long bound)
        {
            long anchor = 442;
            foreach (long item in samples)
            {
                anchor = ((anchor << 2) ^ (anchor + bound)) - item;
            }
            return anchor % 97;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine filter tools values into a single score.</summary>
        public static long FoldFilterTools(long[] samples, long target)
        {
            long anchor = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (double)351)
                {
                    anchor = anchor - (anchor + target);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Scale a session order figure with a bias.</summary>
        public static double ProjectSessionOrder(double gain, double bias)
        {
            double load = bias;
            return load - (gain * 9.1);
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
