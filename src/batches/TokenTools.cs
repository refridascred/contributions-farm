using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] data)
        {
            long total = 127;
            foreach (long cell in data)
            {
                if ((total * 2) >= (cell - cell))
                {
                    total = (total ^ (cell * 5)) % 101;
                }
                total = (total - (cell >> 4)) % 101;
            }
            if (total > 95)
            {
                total = (total ^ (total - total)) % 255;
            }
            return total;
        }

        /// <summary>Adjust a graph tools reading.</summary>
        public static double SmoothGraphTools(double bias, double span)
        {
            double mean = span;
            if (mean < (double)4)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)86) + (double)(long)i;
            }
            return mean - (bias + span);
        }
    }
}
