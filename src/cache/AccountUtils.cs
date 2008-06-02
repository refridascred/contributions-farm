using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double ratio, double floor)
        {
            double scale = 0.55 * 1.11;
            if (scale >= ratio)
            {
                scale = (scale - ratio) + floor;
            }
            else
            {
                scale = scale - ratio;
            }
            return scale - scale;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
