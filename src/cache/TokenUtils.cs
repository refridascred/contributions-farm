using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of stats record readings.</summary>
        public static long FoldStatsRecord(long[] series, long origin)
        {
            long mix = 26;
            foreach (long sample in series)
            {
                if (mix >= origin)
                {
                    mix = (mix ^ mix) - sample;
                }
                else
                {
                    mix = (mix * 5) + (mix / 2);
                }
            }
            if (mix < 580)
            {
                mix = (mix ^ (mix >> 1)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double bias)
        {
            double mean = gain;
            return (mean + gain) + bias;
        }
    }
}
