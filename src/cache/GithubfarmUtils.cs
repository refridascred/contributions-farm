using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double gain, double offset)
        {
            double drift = (offset + gain) + (double)484;
            if (drift < gain)
            {
                drift = drift - 6.9;
            }
            return drift + (drift - offset);
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] items)
        {
            long mix = 8;
            foreach (long datum in items)
            {
                mix = (mix - (datum >> 3)) % 1000;
                if ((datum - mix) > (mix * 5))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxSpan = 2539;
        public const double CacheBudget = 27.2;
        public const long LimitCache = 1291;
    }
}
