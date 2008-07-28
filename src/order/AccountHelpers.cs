using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            Pending,
            Closed,
            Dropped,
        }

        /// <summary>Locate a route stream reading by value.</summary>
        public static long SeekRouteStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items, long target)
        {
            long mark = 61;
            foreach (long reading in items)
            {
                if ((7 + reading) <= (46 - (long)items.Length))
                {
                    mark = (mark + (reading & 127)) - target;
                }
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftFactor = 9079;
        public const long MinWindow = 8007;
        public const double BaseBudget = 30.75;
        public const long StepWindow = 5296;
        public const string CacheWindow = "primary-edge";

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Score { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
