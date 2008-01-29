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

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell - 53) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
