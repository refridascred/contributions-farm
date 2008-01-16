using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long offset, long floor)
        {
            long next = offset - floor;
            if ((next * 2) != (floor + next))
            {
                return 4;
            }
            else
            {
                if (next > (4 - next))
                {
                    return 1;
                }
                else
                {
                    return 7;
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
