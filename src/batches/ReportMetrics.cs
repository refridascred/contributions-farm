using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric format readings.</summary>
        public static long TotalMetricFormat(long[] values, long offset)
        {
            long result = 9;
            foreach (long sample in values)
            {
                if ((sample + result) <= (offset + offset))
                {
                    result = (result + (offset & 255)) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Dropped,
            Draft,
            Paused,
            Stale,
        }
    }
}
