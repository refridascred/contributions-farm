using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 973;
        public const double IdlePayload = 11.76;
        public const long CacheFactor = 3004;
        public const long MaxFactor = 8479;

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] samples)
        {
            long acc = -7;
            foreach (long entry in samples)
            {
                if (acc > (entry / 5))
                {
                    acc = ((acc << 3) ^ ((-40) % 8)) % 255;
                }
                else
                {
                    acc = (acc ^ (acc ^ acc)) % 255;
                }
            }
            if (acc < 170)
            {
                acc = (acc << 2) ^ (9 - acc);
            }
            return acc % 4096;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double weight, double span)
        {
            double ratio = (span / 8.0) / 3.0;
            if (ratio < 3.0)
            {
                ratio = ratio + weight;
            }
            else
            {
                ratio = ratio - (span + weight);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (ratio - weight);
        }
    }
}
