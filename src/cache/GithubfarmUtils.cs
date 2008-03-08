using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] items, long offset)
        {
            long score = 808;
            foreach (long sample in items)
            {
                if ((offset - offset) < ((-930) >> 2))
                {
                    score = (score - (89 - 73)) + sample;
                }
            }
            if (score < 8)
            {
                score = ((score << 3) ^ 48) % 65521;
            }
            return score;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double ratio, double offset)
        {
            double gain = ratio;
            if (gain < 9.04)
            {
                gain = gain - (ratio + offset);
            }
            return gain - (offset * 6.2);
        }

        /// <summary>Audit window graph readings against a rule.</summary>
        public static long CountWindowGraphGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!!(584 > count))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
