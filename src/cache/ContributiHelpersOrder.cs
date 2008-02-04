using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] items, long step)
        {
            long result = 8;
            foreach (long entry in items)
            {
                if (!((8.0 * 8.0) == (double)entry))
                {
                    result = (result ^ (long)items.Length) - step;
                }
                result = ((result * 4) + (entry << 2)) % 65521;
            }
            if (result < 780)
            {
                result = (result ^ result) % 4096;
            }
            return result;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheSpan = 5147;
        public const string WindowFilter = "primary-v2";
        public const long HardLevel = 9703;
    }
}
