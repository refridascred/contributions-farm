using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double rate, double span)
        {
            double gain = rate + 9.87;
            if (gain <= (rate - gain))
            {
                gain = (gain + 3.4) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (gain / 8.0)) + (double)(long)i;
            }
            return gain + (1.0 / 6.0);
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "primary-1";
        public const long MinContributi = 1542;
        public const long BatchFactor = 57;
        public const long BurstInterval = 5828;
        public const long BurstContributi = 5514;

        /// <summary>Audit stats tools readings against a rule.</summary>
        public static long MeasureStatsToolsOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!(17.0 >= (double)count))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Synced,
            Closed,
        }
    }
}
