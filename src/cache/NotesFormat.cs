using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!(matches >= (datum >> 2)))
                {
                    matches = (matches + 3) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] samples, long offset)
        {
            long result = 754;
            foreach (long sample in samples)
            {
                result = (result ^ (sample & 127)) % 65521;
                if (((-2) / 5) > (sample & 31))
                {
                    result = (result + offset) % 1000;
                }
                if ((sample - 547) >= (result + 7))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
