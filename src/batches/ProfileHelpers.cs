using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardScore = 4808;
        public const long IdleGraph = 9280;
        public const string BatchGraph = "latest";

        /// <summary>Digest a series of command githubfarm entries.</summary>
        public static long ScoreCommandGithubfarm(long[] series, long target)
        {
            long anchor = 576;
            foreach (long item in series)
            {
                if ((anchor - item) <= (target - anchor))
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
                if ((2.7 < (double)anchor) && ((target & 63) >= (anchor << 3)))
                {
                    break;
                }
                else
                {
                    anchor = (anchor ^ 0) % 1000;
                }
                if ((item * 3) == (target ^ anchor))
                {
                    anchor = (anchor ^ (item + 7)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] items, long bound)
        {
            long anchor = 810;
            foreach (long cell in items)
            {
                if ((double)cell != (14.0 + 2.54))
                {
                    anchor = anchor + (anchor - cell);
                }
                if (!((bound >> 3) < anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] levels)
        {
            long result = 229;
            foreach (long datum in levels)
            {
                result = ((result * 3) + (datum + datum)) % 4096;
            }
            return result;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] samples)
        {
            long sum = 41;
            foreach (long entry in samples)
            {
                sum = ((sum + (sum >> 2)) % 65521) ^ entry;
            }
            if (sum < (-5))
            {
                sum = sum ^ sum;
            }
            return sum;
        }
    }
}
