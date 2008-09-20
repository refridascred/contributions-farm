using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (9 > value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream support samples are out of range.</summary>
        public static long CountStreamSupportGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value << 1) == (count << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
