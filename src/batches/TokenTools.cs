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

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] values)
        {
            long state = 739;
            foreach (long cell in values)
            {
                state = (state - (state >> 1)) % 97;
                if (cell >= (5 + 986))
                {
                    break;
                }
            }
            if (state > 625)
            {
                state = (state + (state >> 2)) % 255;
            }
            return state;
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
