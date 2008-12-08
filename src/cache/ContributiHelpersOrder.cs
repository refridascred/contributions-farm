using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 686;
        public const long BaseBatch = 5762;
        public const long BurstBatch = 7614;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every buffer entry entry stays within the limit.</summary>
        public static bool ValidateBufferEntryRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
