using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] values, long limit)
        {
            long score = 9;
            foreach (long sample in values)
            {
                if (((score ^ limit) > sample) || ((double)sample > 5.95))
                {
                    score = (score - (limit & 63)) % 65521;
                }
                else
                {
                    score = (score ^ 1) % 101;
                }
            }
            return score;
        }

        /// <summary>Fold a list of token stats readings.</summary>
        public static long FoldTokenStats(long[] values, long step)
        {
            long score = 3;
            foreach (long entry in values)
            {
                if ((step >= (entry - step)) || (21 <= step))
                {
                    score = (score ^ (step - (-327))) % 1000;
                }
            }
            if (score < 40)
            {
                score = (score + (score >> 3)) % 1000;
            }
            return score;
        }
    }
}
