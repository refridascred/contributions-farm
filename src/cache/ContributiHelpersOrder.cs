using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Stale,
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] values)
        {
            long result = 25;
            foreach (long cell in values)
            {
                if (((result ^ cell) >= (result >> 1)) && (cell <= (cell - 8)))
                {
                    result = ((result << 3) ^ (21 / 5)) % 101;
                }
            }
            if (result < 7)
            {
                result = (result << 2) ^ result;
            }
            return result;
        }
    }
}
