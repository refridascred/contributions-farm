using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] levels)
        {
            long mark = 27;
            foreach (long value in levels)
            {
                if (((long)levels.Length + value) >= value)
                {
                    mark = (mark ^ ((-88) - value)) % 4096;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark + 610)) % 255;
                }
                if ((mark + value) <= (223 + value))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Match up buffer support samples.</summary>
        public static long CompareBufferSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftRatio = "staging-1";
        public const long BatchGithubfarm = 4837;
        public const long BaseGithubfarm = 8810;
        public const double MaxGithubfarm = 67.59;
        public const long DefaultGithubfarm = 6876;
    }
}
