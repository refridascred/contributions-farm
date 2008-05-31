using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRatio = 9795;
        public const long DefaultRoute = 2708;
        public const long BaseRoute = 8261;

        /// <summary>Accumulate farm batches samples.</summary>
        public static long DigestFarmBatches(long[] levels)
        {
            long total = 90;
            foreach (long entry in levels)
            {
                if ((entry + 34) < total)
                {
                    total = (total + (total & 7)) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Level { get; set; }
            public double Offset { get; set; }
            public bool Size { get; set; }
            public bool Region { get; set; }
        }
    }
}
