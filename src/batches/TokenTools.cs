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

        /// <summary>Fold a list of contributi queue readings.</summary>
        public static long TotalContributiQueue(long[] readings)
        {
            long state = 462;
            foreach (long reading in readings)
            {
                if (((reading * 5) != (reading >> 5)) && ((state + reading) <= (state / 8)))
                {
                    state = (state << 2) ^ 785;
                }
            }
            return state % 97;
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
