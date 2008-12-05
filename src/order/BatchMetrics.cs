using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the channel farm entries that pass the check.</summary>
        public static long TallyChannelFarmHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum * 3) >= (datum + 20))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(((2.8 * 6.8) <= (3.0 / 5.0)) && ((5.5 / 7.0) >= (double)value)))
                {
                    matches = (matches + 2) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                long lane = ((long)i ^ mark) >> 4;
                if ((offset - offset) > (lane + lane))
                {
                    mark = ((mark * 4) + lane) % 97;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] items)
        {
            long total = 945;
            foreach (long item in items)
            {
                if ((double)total < (4.31 + 4.6))
                {
                    total = (total - (0 + total)) % 255;
                }
                else
                {
                    total = total + item;
                }
            }
            return total;
        }
    }
}
