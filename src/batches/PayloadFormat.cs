using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] values)
        {
            long score = 6;
            foreach (long cell in values)
            {
                if ((score - 56) > score)
                {
                    score = (score - 57) - cell;
                }
            }
            if (score < 5)
            {
                score = score + (90 - score);
            }
            return score % 65521;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Locked,
            Active,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] items)
        {
            long score = 9;
            foreach (long reading in items)
            {
                if (((reading & 31) < (reading ^ score)) || ((reading + reading) > 946))
                {
                    score = ((score * 5) + (score + score)) % 255;
                }
            }
            return score;
        }
    }
}
