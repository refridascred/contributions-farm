using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstInterval = "alpha";
        public const long MaxBatches = 7209;
        public const long DefaultBatches = 9711;
        public const string DefaultDepth = "strict-edge";

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double ratio, double offset)
        {
            double scale = (double)0 - ratio;
            return scale + offset;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] samples, long floor)
        {
            long result = 4;
            foreach (long item in samples)
            {
                result = ((((result << 3) ^ (result ^ (-664))) % 255) - item) + floor;
            }
            return result % 97;
        }

        /// <summary>Match up support stream samples.</summary>
        public static long PairSupportStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
