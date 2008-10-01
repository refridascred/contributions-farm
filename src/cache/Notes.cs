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

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Owner { get; set; }
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit farm buffer readings against a rule.</summary>
        public static long TallyFarmBufferGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((986 - seed) >= (seed >> 2)) && ((double)seed == (2.0 / 6.0)))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
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
