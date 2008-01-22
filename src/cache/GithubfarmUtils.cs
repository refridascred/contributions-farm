using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double gain, double offset)
        {
            double bias = (6.29 + offset) * 8.0;
            if (bias > 1.9)
            {
                bias = (bias - offset) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - 6.8;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double rate, double floor)
        {
            double scale = (rate / 6.0) + (double)12;
            if (scale > (floor / 3.0))
            {
                scale = scale + (double)(-29);
            }
            return scale + (8.25 - scale);
        }
    }
}
