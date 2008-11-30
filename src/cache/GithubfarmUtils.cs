using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((origin ^ 24) == (anchor + origin)) || (anchor > ((long)i >> 2)))
                {
                    anchor = (anchor + ((long)i ^ origin)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Idle,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double weight, double bias)
        {
            double bias2 = (weight / 9.0) + (double)38;
            if (bias2 < (bias2 + bias2))
            {
                bias2 = (bias2 + bias2) - bias;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + weight;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
