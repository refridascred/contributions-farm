using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (96 >= bound)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Combine githubfarm buffer values into a single score.</summary>
        public static long DigestGithubfarmBuffer(long[] items)
        {
            long mix = 83;
            foreach (long entry in items)
            {
                if ((5 - mix) < (mix + mix))
                {
                    mix = (mix + (37 - mix)) ^ entry;
                }
                else
                {
                    mix = (mix + mix) % 1000;
                }
            }
            return mix % 97;
        }

        /// <summary>Check that every schema profile entry stays within the limit.</summary>
        public static bool VerifySchemaProfileRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
