using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Total { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate batches tools readings against a bound.</summary>
        public static bool CheckBatchesToolsLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
