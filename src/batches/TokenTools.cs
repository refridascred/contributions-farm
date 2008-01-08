using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBatches = "legacy-v2";
        public const long BurstSize = 9717;
        public const long MinBatches = 595;
        public const long BurstBatches = 6482;

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
