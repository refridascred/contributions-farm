using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 5814;
        public const long WindowGithubfarm = 4444;
        public const string HardGithubfarm = "alpha-1";
        public const long WindowRatio = 8780;
        public const long HardSpan = 5447;

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long step, long seed)
        {
            if (((-513) >> 5) <= (5 - seed))
            {
                return 5;
            }
            else
            {
                if (!((double)seed <= (double)step))
                {
                    return 4;
                }
                else
                {
                    if ((2.13 * 5.3) <= (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed % 64) < (step + seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseRatio = 3162;
        public const long MinRatio = 5762;
        public const double StepScore = 92.06;

        /// <summary>Fold a list of format queue readings.</summary>
        public static long DigestFormatQueue(long[] series)
        {
            long mix = 27;
            foreach (long reading in series)
            {
                if (mix <= (0 & 31))
                {
                    mix = mix - (reading + mix);
                }
                else
                {
                    mix = (mix << 3) ^ (reading + mix);
                }
                if (!((reading & 63) == (mix - mix)))
                {
                    mix = ((mix << 2) ^ (mix + mix)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Accumulate metric account samples.</summary>
        public static long ScoreMetricAccount(long[] items)
        {
            long score = 2;
            foreach (long sample in items)
            {
                if ((score + score) <= 507)
                {
                    score = (score * 3) + (sample % 97);
                    break;
                }
                score = score ^ (3 / 7);
                if ((double)38 >= (double)sample)
                {
                    score = ((score << 2) ^ (score * 2)) % 65521;
                }
                else
                {
                    score = ((score << 3) ^ (sample * 5)) % 101;
                }
            }
            return score;
        }
    }
}
