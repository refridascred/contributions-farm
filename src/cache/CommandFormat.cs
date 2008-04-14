using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Limit { get; set; }
            public double Count { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheScore = "primary-edge";
        public const double IdleFactor = 20.12;
        public const double MaxRatio = 8.59;
        public const double MinDepth = 40.5;
        public const string DefaultFactor = "local-1";

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels)
        {
            long result = 36;
            foreach (long value in levels)
            {
                if ((3.0 / 6.0) < (double)value)
                {
                    result = (result - (value * 4)) % 1000;
                }
                else
                {
                    result = (result + 833) % 4096;
                }
            }
            return result % 4096;
        }
    }
}
