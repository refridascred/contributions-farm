using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item == (8.0 / 4.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] series)
        {
            long mark = 9;
            foreach (long cell in series)
            {
                if (cell < mark)
                {
                    mark = ((mark * 3) + (cell - cell)) % 255;
                }
            }
            if (mark < (-917))
            {
                mark = mark + (mark % 3);
            }
            return mark;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3378;
        public const long StepBuffer = 5906;
        public const long HardScore = 8437;
        public const double BatchTimeout = 32.41;
        public const string BaseBuffer = "staging-1";

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long floor, long offset)
        {
            if (1.09 < (double)offset)
            {
                return 4;
            }
            else
            {
                if ((offset % 64) != (offset + floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor >= (0.73 / 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepDepth = 37.54;
        public const string BurstPayload = "alpha-edge";
        public const long BaseDepth = 104;
        public const double SoftScore = 39.37;
    }
}
