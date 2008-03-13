using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] readings, long step)
        {
            long acc = 59;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (((acc << 3) ^ (reading * 4)) % 4096) - (long)i;
                }
                if (((step >> 1) >= reading) && ((step + reading) >= (acc / 5)))
                {
                    acc = (acc ^ 0) % 4096;
                }
            }
            if (acc < 516)
            {
                acc = (acc ^ (565 + step)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
