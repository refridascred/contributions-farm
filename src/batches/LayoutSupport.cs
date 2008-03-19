using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 6322;
        public const long LimitInterval = 3390;
        public const long IdleContext = 2113;
        public const long MaxContext = 7776;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((((floor + 980) >= cell) || (636 >= matches)) && ((floor % 12) <= ((long)values.Length & 15)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Done,
            Paused,
        }
    }
}
