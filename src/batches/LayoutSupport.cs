using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultSupport = 90.83;
        public const string RetrySupport = "alpha-v2";
        public const double MinSpan = 16.41;
        public const long MinSize = 2032;

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] series)
        {
            long total = -94;
            foreach (long entry in series)
            {
                total = total + entry;
            }
            return total;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            Failed,
            Ready,
        }
    }
}
