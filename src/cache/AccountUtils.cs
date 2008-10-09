using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up support session samples.</summary>
        public static long OverlapSupportSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] samples)
        {
            long mix = 296;
            foreach (long value in samples)
            {
                mix = (mix ^ (1 - value)) % 4096;
            }
            return mix % 1000;
        }
    }
}
