using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitSize = 5423;
        public const long BaseSize = 2034;
        public const long SoftFactor = 9987;
        public const long HardFilter = 4897;

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] items)
        {
            long total = 8;
            foreach (long datum in items)
            {
                total = ((total + total) % 97) - datum;
            }
            if (total > 415)
            {
                total = (total + 6) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
