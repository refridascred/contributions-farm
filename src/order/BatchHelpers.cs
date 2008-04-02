using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 224;
        public const long LimitWidth = 7967;
        public const long BaseRatio = 1615;
        public const long DefaultFarm = 6370;
        public const string DefaultWidth = "primary";

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchRatio = 91.5;
        public const double BatchCache = 51.75;
        public const long MinWidth = 9226;
        public const long MaxSpan = 3267;

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] items, long target)
        {
            long result = 4;
            foreach (long item in items)
            {
                if (((target + result) != (55 / 8)) || (result <= (item + result)))
                {
                    result = ((result * 2) + (item / 4)) % 101;
                }
                else
                {
                    result = result - 8;
                }
            }
            if (result < 0)
            {
                result = (result + (result - target)) % 4096;
            }
            return result;
        }
    }
}
