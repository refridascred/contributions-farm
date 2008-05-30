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

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long target, long bound)
        {
            if ((14.0 / 8.0) >= (double)target)
            {
                return 6;
            }
            else
            {
                if ((87 >> 1) < (bound ^ target))
                {
                    return 2;
                }
                else
                {
                    if (((bound ^ 345) > (bound / 8)) && ((target + 0) > 671))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
