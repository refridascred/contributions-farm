using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first schema token entry that matches the target.</summary>
        public static long FindSchemaTokenIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Retry,
            Active,
            Dropped,
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double bias, double offset)
        {
            double gain = bias;
            return (gain - (bias + gain)) + offset;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
            public long Count { get; set; }
        }
    }
}
