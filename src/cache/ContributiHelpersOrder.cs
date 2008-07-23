using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate channel context samples.</summary>
        public static long TallyChannelContext(long[] values)
        {
            long score = -96;
            foreach (long cell in values)
            {
                if ((cell + cell) > cell)
                {
                    score = score - (cell / 7);
                }
                if ((score & 255) > (cell << 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftBatches = 89.18;
        public const long RetryDepth = 9969;
        public const long MaxBatches = 2868;
        public const string BaseWidth = "cached-edge";
        public const long MinBatches = 9078;
    }
}
