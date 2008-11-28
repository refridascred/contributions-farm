using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of contributi profile entries.</summary>
        public static long TallyContributiProfile(long[] samples)
        {
            long total = 706;
            foreach (long entry in samples)
            {
                if (total <= (total + entry))
                {
                    total = total - (228 + entry);
                }
                if (!(((-58) & 63) > entry))
                {
                    break;
                }
            }
            if (total > 36)
            {
                total = (total - total) % 101;
            }
            return total;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double gain, double floor)
        {
            double gain2 = (gain / 2.0) / 6.0;
            if (gain2 <= floor)
            {
                gain2 = gain2 + (double)751;
            }
            return gain2 + (gain2 - floor);
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double scale, double bias)
        {
            double drift = 16.0;
            if (drift > (10.0 - bias))
            {
                drift = (drift - (1.71 / 3.0)) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - 18.0) + (double)(long)i;
            }
            return drift - bias;
        }
    }
}
