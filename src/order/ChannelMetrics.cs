using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many token entry samples are out of range.</summary>
        public static long CountTokenEntryMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches * 4) < (matches >> 3))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] readings, long seed)
        {
            long carry = 72;
            foreach (long cell in readings)
            {
                if ((cell >> 3) >= seed)
                {
                    carry = (carry - carry) % 4096;
                }
            }
            if (carry > 38)
            {
                carry = carry ^ (seed + carry);
            }
            return carry % 65521;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((2 >> 2) > (bound + count)) && (5 >= bound))
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
