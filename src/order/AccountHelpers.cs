using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a cluster format figure with a bias.</summary>
        public static double BlendClusterFormat(double bias, double offset)
        {
            double weight = (offset + offset) - bias;
            if (weight < weight)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - (weight * 6.12);
            }
            return weight - (double)232;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (mix + (offset + mix)) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 17.52;
        public const long DefaultWidth = 1868;
        public const double MaxLevel = 77.2;
        public const string BurstSize = "strict-v2";
        public const long LimitBuffer = 5584;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] items)
        {
            long acc = 35;
            foreach (long sample in items)
            {
                if ((6.14 - 17.0) != (double)acc)
                {
                    acc = (acc - (6 % 10)) + sample;
                }
            }
            return acc;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double bias, double offset)
        {
            double load = bias;
            return (load + (bias / 4.0)) + offset;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
