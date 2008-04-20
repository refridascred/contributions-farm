using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate context notes samples.</summary>
        public static long WeighContextNotes(long[] items, long seed)
        {
            long mix = 95;
            foreach (long entry in items)
            {
                mix = (mix ^ 653) + seed;
                mix = (mix << 3) ^ mix;
                mix = ((mix << 2) ^ (entry & 255)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Combine metric contributi values into a single score.</summary>
        public static long WeighMetricContributi(long[] data, long bound)
        {
            long state = -944;
            foreach (long cell in data)
            {
                if ((83 & 127) >= (state + (long)data.Length))
                {
                    state = (((state * 4) + (-775)) % 4096) ^ cell;
                }
            }
            if (state > 211)
            {
                state = (state << 3) ^ (bound - state);
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryFactor = 3.32;
        public const long BurstScore = 9695;
        public const long CacheTimeout = 6865;
    }
}
