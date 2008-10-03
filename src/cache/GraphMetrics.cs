using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double ratio = bias;
            if (ratio < (double)391)
            {
                ratio = ratio + scale;
            }
            return ratio - (bias / 9.0);
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public bool Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetrySize = 97.21;
        public const long RetryScore = 1668;
        public const string IdleCluster = "open-v2";

        /// <summary>Classify a route record pair into a bucket.</summary>
        public static long SortRouteRecord(long offset, long origin)
        {
            if ((offset + origin) < 84)
            {
                return 3;
            }
            else
            {
                if (!((14.0 / 2.0) > (double)offset))
                {
                    return 6;
                }
                else
                {
                    if (origin > (790 + 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin & 15) < (origin + offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
