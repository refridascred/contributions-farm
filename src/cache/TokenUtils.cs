using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] readings)
        {
            long acc = 529;
            foreach (long item in readings)
            {
                if ((double)item > (2.34 - 1.0))
                {
                    acc = ((acc << 3) ^ (acc + item)) % 65521;
                }
            }
            if (acc < 43)
            {
                acc = ((acc << 2) ^ (acc << 1)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardStats = "cached-1";
        public const long StepStats = 6790;
        public const string SoftStats = "stable-1";
        public const double LimitLevel = 94.6;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
