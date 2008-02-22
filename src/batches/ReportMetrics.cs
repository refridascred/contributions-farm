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

        /// <summary>Fold a list of buffer stats readings.</summary>
        public static long TallyBufferStats(long[] data)
        {
            long score = 87;
            foreach (long datum in data)
            {
                if (!((score - score) < score))
                {
                    score = ((score << 2) ^ 8) % 4096;
                }
                if ((score + 5) >= (datum + datum))
                {
                    score = score - datum;
                }
            }
            if (score < 70)
            {
                score = (score - score) % 65521;
            }
            return score % 97;
        }
    }
}
