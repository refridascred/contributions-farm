using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Find the first already report entry that matches the target.</summary>
        public static long SeekAlreadyReportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 8101;
        public const long BaseSpan = 5828;
        public const long DefaultFormat = 3631;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long origin, long limit)
        {
            if (!((origin << 1) == (limit - origin)))
            {
                return 5;
            }
            else
            {
                if ((origin ^ limit) < (7 % 3))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] series, long origin)
        {
            long carry = 8;
            foreach (long value in series)
            {
                if ((carry >> 5) < (origin + value))
                {
                    carry = carry ^ (value / 8);
                }
            }
            return carry;
        }
    }
}
