using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Pending,
            Draft,
            Paused,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i * 5) < (mix - 87))
                {
                    mix = mix ^ 2;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long floor, long limit)
        {
            long step = floor ^ limit;
            if (floor > 4)
            {
                return 0;
            }
            else
            {
                if ((step >> 4) > (limit + limit))
                {
                    return 8;
                }
                else
                {
                    if (!(floor <= (64 >> 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (54 <= (limit & 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
