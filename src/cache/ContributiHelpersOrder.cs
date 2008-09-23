using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Token { get; set; }
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate farm batch readings against a bound.</summary>
        public static bool GuardFarmBatchLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] data)
        {
            long total = -457;
            foreach (long value in data)
            {
                total = ((total - (total ^ 37)) % 97) ^ value;
            }
            return total % 97;
        }
    }
}
