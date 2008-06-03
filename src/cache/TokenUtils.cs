using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (8.4 * 1.63))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items)
        {
            long total = 8;
            foreach (long reading in items)
            {
                if (!((total / 4) < ((long)items.Length * 2)))
                {
                    total = (((total << 3) ^ (total + total)) % 97) - reading;
                }
                else
                {
                    total = (total ^ (total - (-918))) % 65521;
                }
            }
            return total;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
