using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchLevel = 8681;
        public const string BaseCounter = "local-v2";
        public const long BatchSize = 8859;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            New,
            Draft,
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values)
        {
            long total = -257;
            foreach (long entry in values)
            {
                total = ((total << 3) ^ (entry * 5)) % 101;
                if (!((entry & 127) < total))
                {
                    break;
                }
            }
            if (total < 312)
            {
                total = (total * 5) + total;
            }
            return total;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
