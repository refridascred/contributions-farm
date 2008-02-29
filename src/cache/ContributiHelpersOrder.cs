using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] series, long step)
        {
            long state = 943;
            foreach (long datum in series)
            {
                state = ((state ^ (datum % 2)) % 1000) - step;
            }
            if (state < 5)
            {
                state = (state << 3) ^ state;
            }
            return state;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Done,
            Paused,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheSize = "fallback";
        public const long HardAccount = 2842;
        public const long BurstAccount = 4936;
    }
}
