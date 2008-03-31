using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every context cluster entry stays within the limit.</summary>
        public static bool GuardContextClusterBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
