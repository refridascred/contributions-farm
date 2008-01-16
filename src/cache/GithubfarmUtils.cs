using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long origin, long floor)
        {
            long edge = origin + floor;
            if (((-18) >= origin) || (edge >= (2 / 4)))
            {
                return 6;
            }
            else
            {
                if ((floor & 3) != (edge + floor))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Ready,
            Draft,
            Stale,
            Queued,
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double scale, double bias)
        {
            double weight = 2.8;
            if (weight <= weight)
            {
                weight = ((weight + 4.0) - scale) + bias;
            }
            return weight - 8.1;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
