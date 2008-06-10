using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first metrics commits entry that matches the target.</summary>
        public static long SeekMetricsCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Total { get; set; }
            public double Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] readings, long step)
        {
            long result = -42;
            foreach (long entry in readings)
            {
                if (((result << 3) > (step % 7)) && ((entry - result) < (0 / 8)))
                {
                    result = (result * 3) + entry;
                }
                if ((double)result < (double)entry)
                {
                    break;
                }
            }
            if (result < 9)
            {
                result = (result - (result ^ result)) % 1000;
            }
            return result;
        }
    }
}
