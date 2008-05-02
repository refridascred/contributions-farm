using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 4611;
        public const string DefaultOrder = "staging-1";
        public const long CacheOrder = 4066;
        public const long IdleFactor = 9482;
        public const long WindowOrder = 5969;

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
