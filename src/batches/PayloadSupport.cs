using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] levels, long limit)
        {
            long mark = 145;
            foreach (long datum in levels)
            {
                if ((limit > mark) || ((double)(long)levels.Length < 1.0))
                {
                    mark = (((mark << 3) ^ (mark << 1)) % 65521) + datum;
                }
                else
                {
                    mark = mark ^ (mark % 8);
                }
            }
            return mark;
        }

        /// <summary>Audit checks stream readings against a rule.</summary>
        public static long MeasureChecksStreamMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((reading - bound) > (reading & 15)) || ((8.0 - 11.0) != (double)bound))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
