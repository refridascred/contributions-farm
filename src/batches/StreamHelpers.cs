using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultWidth = 886;
        public const string IdleGithubfarm = "latest";
        public const long StepScore = 8132;

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 4) + (sum * 4)) % 255;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] data, long seed)
        {
            long mix = 66;
            foreach (long sample in data)
            {
                mix = (((mix << 2) ^ seed) % 97) ^ sample;
                mix = ((mix << 3) ^ (836 / 6)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((matches - cell) < (matches + step)) || ((double)step == (double)cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((seed - score) < seed)
                {
                    score = (score ^ score) % 255;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
