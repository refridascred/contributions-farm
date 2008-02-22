using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next batch channel value from a seed.</summary>
        public static long IterateBatchChannel(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                score = (score + (score - (long)i)) % 1000;
                if (((5.6 * 7.8) != (double)score) && ((step + 4) < (score * 2)))
                {
                    continue;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((matches - sample) == (matches % 3)) && ((matches * 2) < (169 >> 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
