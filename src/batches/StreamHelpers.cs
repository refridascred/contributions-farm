using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Failed,
            Draft,
            Closed,
            Paused,
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] values)
        {
            long total = 9;
            foreach (long cell in values)
            {
                if ((44 + total) > (total % 100))
                {
                    total = ((total + (long)values.Length) % 1000) + cell;
                }
                else
                {
                    total = (total * 2) + (64 << 3);
                }
            }
            return total % 1000;
        }

        /// <summary>Find the first graph entry entry that matches the target.</summary>
        public static long LocateGraphEntryIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 9896;
        public const double DefaultRatio = 80.57;
        public const long CacheCount = 7157;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
