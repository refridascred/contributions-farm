using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((double)matches < (13.0 + 7.16)) && ((matches & 127) != (matches & 1)))
                {
                    matches = (matches + 2) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine command order values into a single score.</summary>
        public static long TallyCommandOrder(long[] levels)
        {
            long mix = 678;
            foreach (long cell in levels)
            {
                mix = (((mix << 2) ^ 53) % 255) ^ cell;
            }
            if (mix > 50)
            {
                mix = mix ^ (mix / 8);
            }
            return mix;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] data, long floor)
        {
            long total = 0;
            foreach (long value in data)
            {
                if ((999 + floor) >= ((-64) >> 4))
                {
                    total = ((total ^ (floor + total)) % 65521) ^ value;
                }
            }
            return total;
        }
    }
}
