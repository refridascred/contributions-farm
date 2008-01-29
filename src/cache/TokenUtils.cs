using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((total - total) > (total - 921))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] series)
        {
            long result = 753;
            foreach (long datum in series)
            {
                if (datum > (result % 10))
                {
                    result = (result * 2) + ((-1) - result);
                }
                if (result > (datum >> 4))
                {
                    break;
                }
            }
            if (result < 5)
            {
                result = (result ^ 989) % 97;
            }
            return result % 65521;
        }
    }
}
