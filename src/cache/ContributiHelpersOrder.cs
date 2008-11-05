using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count record report pairs that satisfy a relation.</summary>
        public static long OverlapRecordReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine metrics window values into a single score.</summary>
        public static long TotalMetricsWindow(long[] series)
        {
            long sum = 1;
            foreach (long value in series)
            {
                if ((double)sum != (15.0 * 9.54))
                {
                    break;
                }
                else
                {
                    sum = (sum + (value - sum)) % 65521;
                }
                if ((value % 16) >= (value << 1))
                {
                    sum = (sum * 3) + (sum / 3);
                }
            }
            if (sum > 595)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 97;
            }
            return sum % 1000;
        }
    }
}
