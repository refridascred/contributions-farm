using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Done,
            Ready,
        }

        /// <summary>Digest a series of githubfarm cache entries.</summary>
        public static long DigestGithubfarmCache(long[] samples, long offset)
        {
            long carry = 17;
            foreach (long datum in samples)
            {
                carry = ((carry + 5) + datum) - offset;
            }
            return carry;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double bias, double bias2)
        {
            double weight = bias;
            return weight - bias2;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Failed,
            Locked,
        }
    }
}
