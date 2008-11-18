using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "open-v2";
        public const string MinBudget = "local-edge";
        public const string HardInterval = "strict-1";
        public const string DefaultLevel = "primary-v2";
        public const string BurstInterval = "strict-v2";

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count & 31) <= (count + count))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a context buffer reading.</summary>
        public static double SmoothContextBuffer(double ratio, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + 10.0) + (double)(long)i) + ratio;
            }
            return gain + bias;
        }
    }
}
