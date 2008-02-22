using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double bias, double floor)
        {
            double load = floor + (double)499;
            return (load + (17.0 - floor)) + bias;
        }

        /// <summary>Validate window profile readings against a bound.</summary>
        public static bool CheckWindowProfileBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 9132;
        public const long StepScore = 5518;
        public const string MaxLevel = "alpha-edge";
        public const string MinChannel = "latest-v2";
        public const long BurstChannel = 6680;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
