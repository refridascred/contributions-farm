using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double scale, double span)
        {
            double drift = (double)((-915) - (-447));
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + (drift * 2.07)) - (double)(long)i) - span;
            }
            return drift - scale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstWidth = 9712;
        public const string WindowSize = "stable-edge";
        public const long BatchFactor = 9083;
    }
}
