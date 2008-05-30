using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count order checks pairs that satisfy a relation.</summary>
        public static long OverlapOrderChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                if (!(((score - seed) != (score * 2)) || (83 <= (score + seed))))
                {
                    score = ((score * 2) + ((-6) ^ (long)i)) % 4096;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
