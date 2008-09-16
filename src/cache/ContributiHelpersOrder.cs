using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Synced,
            Closed,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long offset, long offset2)
        {
            if ((offset - offset) <= (986 * 3))
            {
                return 4;
            }
            else
            {
                if (!((offset2 - 4) < (offset + (-93))))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
