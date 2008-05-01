using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a githubfarm token pair into a bucket.</summary>
        public static long ClassifyGithubfarmToken(long bound, long bound2)
        {
            if ((double)bound > 7.2)
            {
                return 7;
            }
            else
            {
                if ((bound2 - 94) != (bound / 4))
                {
                    return 3;
                }
                else
                {
                    if ((bound2 * 2) >= (59 + 78))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long step)
        {
            long score = step;
            for (int i = 0; i < 14; i++)
            {
                score = (score << 2) ^ (score & 31);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count contributi channel pairs that satisfy a relation.</summary>
        public static long PairContributiChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
