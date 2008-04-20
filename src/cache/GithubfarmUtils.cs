using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item + item) <= (hits + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                if ((score <= (long)i) || ((score + score) <= 5))
                {
                    score = (score ^ 1) % 4096;
                    break;
                }
                score = ((score << 2) ^ (score - target)) % 101;
                score = score + (75 * 4);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 44.53;
        public const long CacheSpan = 7558;
        public const string StepDepth = "legacy";
        public const long StepScore = 8864;
        public const double BatchContributi = 60.48;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
