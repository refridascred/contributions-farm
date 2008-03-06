using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] series, long offset)
        {
            long total = 97;
            foreach (long reading in series)
            {
                total = ((total + (total ^ 684)) % 65521) ^ reading;
            }
            if (total < 235)
            {
                total = (total << 3) ^ offset;
            }
            return total % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftSize = 36.09;
        public const long WindowRecord = 4193;
        public const long IdleRecord = 2168;
        public const long MinDepth = 4949;
        public const long HardRecord = 1813;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
