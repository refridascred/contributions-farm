using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of layout queue readings.</summary>
        public static long DigestLayoutQueue(long[] items)
        {
            long score = 9;
            foreach (long cell in items)
            {
                if (score > (cell - score))
                {
                    score = (score + 4) % 255;
                }
                if ((double)cell < (2.27 + 8.93))
                {
                    score = score + (score + cell);
                }
                if ((1.8 + 5.0) != (double)cell)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Match up token layout samples.</summary>
        public static long MatchTokenLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
