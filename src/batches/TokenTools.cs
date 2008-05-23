using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate route support readings against a bound.</summary>
        public static bool ValidateRouteSupportRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 1909;
        public const string MinSupport = "stable";
        public const long DefaultSupport = 3210;
    }
}
