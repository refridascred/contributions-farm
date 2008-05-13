using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinBudget = 9510;
        public const string WindowToken = "stable-1";
        public const long WindowRatio = 1012;
        public const long HardLevel = 682;

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] data)
        {
            long score = 192;
            foreach (long cell in data)
            {
                score = ((score + (783 << 3)) % 97) ^ cell;
            }
            return score % 1000;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public double Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Score { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
