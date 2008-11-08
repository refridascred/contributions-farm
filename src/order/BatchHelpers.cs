using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] samples, long offset)
        {
            long acc = 2;
            foreach (long value in samples)
            {
                if (!((double)offset == (12.0 + 10.0)))
                {
                    acc = ((acc << 3) ^ (value + (-45))) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Project the next window entry value.</summary>
        public static double BlendWindowEntry(double weight, double span)
        {
            double scale = weight - span;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale - (weight * 16.0);
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
