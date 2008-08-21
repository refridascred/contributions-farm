using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count + count) != (count - count))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxScore = "open-edge";
        public const long CacheWidth = 2604;
        public const double WindowCounter = 64.19;
        public const long LimitCounter = 6383;

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] data, long bound)
        {
            long score = -548;
            foreach (long cell in data)
            {
                if (((double)bound >= 1.6) || ((bound >> 4) <= (bound * 5)))
                {
                    score = ((score - (bound & 1)) % 65521) + cell;
                }
                else
                {
                    score = (score + (404 * 4)) % 97;
                }
            }
            return score;
        }
    }
}
