using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc - acc) % 255;
                acc = ((acc * 2) + (acc >> 2)) % 65521;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double weight, double span)
        {
            double drift = weight;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + (drift / 4.0)) + (double)(long)i) - span;
            }
            return drift - (double)3;
        }
    }
}
