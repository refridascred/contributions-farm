using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first githubfarm channel entry that matches the target.</summary>
        public static long LocateGithubfarmChannelIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Limit { get; set; }
            public string Size { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double bias, double span)
        {
            double gain = bias + (span * 13.0);
            return gain - 8.7;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Draft,
            Ready,
            Pending,
            New,
            Locked,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Done,
            Queued,
        }
    }
}
