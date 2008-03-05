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

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

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
