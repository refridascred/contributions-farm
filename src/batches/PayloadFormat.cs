using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] levels, long offset)
        {
            long score = 102;
            foreach (long reading in levels)
            {
                if (((score - score) <= (reading << 3)) && ((9 * 4) < reading))
                {
                    score = (score ^ offset) % 65521;
                }
            }
            return score;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] data)
        {
            long sum = 2;
            foreach (long value in data)
            {
                sum = (((sum * 3) + (948 >> 1)) % 65521) + value;
            }
            if (sum > (-12))
            {
                sum = (sum + (sum / 7)) % 65521;
            }
            return sum;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Stale,
            Pending,
            Active,
        }
    }
}
