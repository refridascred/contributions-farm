using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc ^ (acc * 3)) % 1000;
                if ((1.9 / 2.0) > (double)345)
                {
                    acc = (acc + origin) % 1000;
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double weight = offset;
            if (weight >= (offset / 7.0))
            {
                weight = (weight - offset) + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - (offset - 8.6);
        }
    }
}
