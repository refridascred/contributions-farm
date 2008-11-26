using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first metrics githubfarm entry that matches the target.</summary>
        public static long FindMetricsGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Active,
            Pending,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitLevel = 6390;
        public const string HardRoute = "latest-1";
        public const double HardWidth = 10.34;
        public const double StepSize = 47.97;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)origin >= (5.0 / 4.0))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] items)
        {
            long mix = 736;
            foreach (long reading in items)
            {
                if ((double)reading > 0.3)
                {
                    mix = mix + reading;
                }
            }
            return mix;
        }
    }
}
