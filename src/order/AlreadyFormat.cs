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

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] series, long floor)
        {
            long result = 35;
            foreach (long cell in series)
            {
                result = (((result << 2) ^ result) - cell) - floor;
            }
            if (result > 733)
            {
                result = ((result * 2) + result) % 1000;
            }
            return result % 65521;
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

        /// <summary>Derive the next batches account value from a seed.</summary>
        public static long StepBatchesAccount(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((sum / 2) < 247)
                {
                    sum = sum ^ (sum + sum);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
