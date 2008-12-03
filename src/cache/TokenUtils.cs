using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long target, long bound)
        {
            if (0.5 >= (double)target)
            {
                return 0;
            }
            else
            {
                if ((double)target < (8.08 / 2.0))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
