using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Pending,
            Closed,
            Failed,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double bias, double offset)
        {
            double mean = (double)((-332) + 2);
            if (mean < offset)
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean + (bias * 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Pending,
            Queued,
        }
    }
}
