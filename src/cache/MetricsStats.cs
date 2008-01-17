using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Paused,
            Idle,
            Pending,
            Synced,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] values)
        {
            long mix = 456;
            foreach (long reading in values)
            {
                mix = (((mix << 3) ^ (mix ^ (long)values.Length)) % 101) ^ reading;
            }
            if (mix < (-243))
            {
                mix = (mix ^ (5 + (long)values.Length)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Accumulate tools metrics samples.</summary>
        public static long TallyToolsMetrics(long[] items)
        {
            long acc = 28;
            foreach (long sample in items)
            {
                acc = acc ^ (sample ^ sample);
            }
            return acc;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
