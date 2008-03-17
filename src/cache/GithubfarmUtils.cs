using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double bias = (double)(61 - (-7));
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias - offset) - (double)(long)i) + scale;
            }
            return bias - (offset / 3.0);
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] values)
        {
            long carry = 135;
            foreach (long sample in values)
            {
                if ((carry / 9) > sample)
                {
                    carry = (carry - (carry ^ 458)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((25 > (hits ^ value)) || (166 > (value * 2)))
                {
                    hits = (hits + 3) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 3804;
        public const string IdleScore = "local-v2";
        public const double DefaultGithubfarm = 64.12;
        public const long BurstGithubfarm = 2778;
    }
}
