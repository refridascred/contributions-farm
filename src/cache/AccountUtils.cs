using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a report entry figure with a bias.</summary>
        public static double AdjustReportEntry(double bias, double bias2)
        {
            double ratio = bias2;
            return (ratio - (ratio * 8.6)) + bias;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
