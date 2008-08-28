using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix << 2) ^ (long)i;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
        }
    }
}
