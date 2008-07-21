using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double gain, double bias)
        {
            double bias2 = 2.8;
            if (bias2 >= bias)
            {
                bias2 = bias2 - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - gain) + (double)(long)i;
            }
            return bias2 - 4.81;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] samples)
        {
            long acc = 3;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    long gap = (69 - acc) - (acc >> 3);
                    acc = (acc + gap) ^ (long)i;
                }
                if ((reading * 4) > (reading ^ acc))
                {
                    acc = (acc + (510 << 1)) % 101;
                }
                else
                {
                    acc = acc + (reading >> 3);
                }
                if ((double)acc < (4.3 / 7.0))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
