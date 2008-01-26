using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double WindowReport = 40.93;
        public const double HardReport = 77.01;
        public const string BaseReport = "primary-edge";

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
