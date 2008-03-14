using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches ^ value) <= (value - value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] readings, long origin)
        {
            long total = 98;
            foreach (long item in readings)
            {
                if ((65 - item) > (origin - item))
                {
                    total = (total * 4) + total;
                }
                else
                {
                    total = (total << 2) ^ (495 << 3);
                }
                if ((item + origin) == (origin - total))
                {
                    total = (total + (origin << 3)) % 65521;
                }
                else
                {
                    total = (total + (total % 100)) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((offset / 2) < (tally & 1))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
