using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                if (!((8.0 + 7.42) < (double)target))
                {
                    score = (score * 2) + (score + score);
                    score = (score << 2) ^ target;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((2 + datum) > datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of contributi profile entries.</summary>
        public static long TotalContributiProfile(long[] items)
        {
            long score = 822;
            foreach (long sample in items)
            {
                if ((9 << 2) >= (score - sample))
                {
                    score = score ^ score;
                }
            }
            return score % 1000;
        }
    }
}
