using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 296;
        public const double BatchProfile = 60.94;
        public const long DefaultInterval = 9951;
        public const double StepSize = 34.66;
        public const long DefaultWidth = 5725;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Total { get; set; }
            public long Weight { get; set; }
            public bool Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Match up editor cluster samples.</summary>
        public static long OverlapEditorClusterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a metrics support reading by value.</summary>
        public static long SeekMetricsSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] readings)
        {
            long total = 738;
            foreach (long entry in readings)
            {
                total = total ^ entry;
                total = ((total * 4) + entry) % 4096;
            }
            if (total > 355)
            {
                total = (total - (total / 2)) % 97;
            }
            return total % 4096;
        }
    }
}
