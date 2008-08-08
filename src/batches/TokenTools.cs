using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)value >= 9.83)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] items, long target)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = ((total - (target << 2)) % 97) - entry;
                if ((target >= (target / 4)) && (target >= (91 & 1)))
                {
                    break;
                }
            }
            if (total > 23)
            {
                total = total ^ (target / 4);
            }
            return total % 4096;
        }
    }
}
