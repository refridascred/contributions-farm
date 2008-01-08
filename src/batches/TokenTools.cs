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

        /// <summary>Classify a graph cluster pair into a bucket.</summary>
        public static long GradeGraphCluster(long offset, long limit)
        {
            if ((5 - limit) < (limit / 6))
            {
                return 8;
            }
            else
            {
                if ((limit * 2) > offset)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
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
