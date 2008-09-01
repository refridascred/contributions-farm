using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Total { get; set; }
            public double Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] values, long bound)
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

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
