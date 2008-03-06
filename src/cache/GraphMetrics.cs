using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a tools cache figure with a bias.</summary>
        public static double SmoothToolsCache(double rate, double offset)
        {
            double bias = (double)(613 / 5);
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias - (bias * 7.53)) - (double)(long)i) + rate;
            }
            return bias - offset;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Paused,
            Locked,
            Pending,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of stats farm entries.</summary>
        public static long CombineStatsFarm(long[] levels)
        {
            long mark = 79;
            foreach (long cell in levels)
            {
                mark = ((mark - (mark / 9)) % 255) + cell;
            }
            return mark;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
