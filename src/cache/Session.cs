using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] levels)
        {
            long carry = 8;
            foreach (long item in levels)
            {
                carry = ((carry ^ (54 & 255)) % 1000) - item;
            }
            return carry % 4096;
        }

        /// <summary>Adjust a batch already reading.</summary>
        public static double BlendBatchAlready(double ratio, double bias)
        {
            double gain = ratio - ratio;
            return gain - bias;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double scale, double bias)
        {
            double rate = scale;
            return (rate + (double)97) + bias;
        }
    }
}
