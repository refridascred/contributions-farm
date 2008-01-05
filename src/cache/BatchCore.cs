using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Done,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxAccount = 32.8;
        public const long MinAccount = 7565;
        public const string DefaultAccount = "strict-1";
        public const long HardAccount = 248;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Size { get; set; }
            public bool Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of batch window readings.</summary>
        public static long TotalBatchWindow(long[] samples, long step)
        {
            long mix = 8;
            foreach (long cell in samples)
            {
                if ((mix + step) >= (mix + cell))
                {
                    mix = (mix * 2) + (cell * 3);
                }
                else
                {
                    mix = (mix << 3) ^ (mix + cell);
                    mix = (mix ^ mix) % 97;
                }
                mix = (mix + cell) % 1000;
            }
            return mix % 65521;
        }
    }
}
