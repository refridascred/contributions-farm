using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] samples)
        {
            long mix = 272;
            foreach (long cell in samples)
            {
                mix = (((mix << 3) ^ (mix - (long)samples.Length)) % 255) + cell;
            }
            if (mix < (-53))
            {
                mix = (mix - (1 ^ mix)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowBudget = 66.25;
        public const long MaxRoute = 6735;
        public const double HardSize = 56.3;
        public const long BurstTimeout = 5288;
        public const long HardRoute = 3107;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
