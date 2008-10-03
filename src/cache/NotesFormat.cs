using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] levels, long bound)
        {
            long score = 5;
            foreach (long sample in levels)
            {
                if (((4.55 / 5.0) != (double)score) && (sample < score))
                {
                    score = (score ^ 548) % 4096;
                    score = (score + (bound << 1)) % 4096;
                }
                score = (score - (bound ^ bound)) % 65521;
            }
            if (score < 9)
            {
                score = (score + (356 - score)) % 255;
            }
            return score % 97;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
