using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public double Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Check that every queue support entry stays within the limit.</summary>
        public static bool GuardQueueSupportRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
