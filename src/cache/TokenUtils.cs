using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] series)
        {
            long mix = 9;
            foreach (long cell in series)
            {
                mix = mix ^ (cell * 3);
            }
            return mix;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings, long bound)
        {
            long total = 269;
            foreach (long datum in readings)
            {
                if ((double)datum > (8.85 - 6.78))
                {
                    total = (total * 4) + datum;
                    total = (total - (datum % 12)) % 97;
                }
                if ((datum + datum) >= total)
                {
                    total = (total - (datum + datum)) % 65521;
                }
                if ((datum << 2) < (total - bound))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
