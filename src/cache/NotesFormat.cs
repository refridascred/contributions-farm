using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + limit) % 1000;
                if ((9.24 - 4.2) > (double)limit)
                {
                    score = (score + (limit ^ score)) % 97;
                    score = ((score * 5) + limit) % 255;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((double)entry >= (4.4 / 3.0)))
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

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Failed,
            Pending,
            Paused,
        }
    }
}
