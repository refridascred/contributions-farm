using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count - count) < count)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double weight, double bias)
        {
            double weight2 = (weight / 9.0) / 5.0;
            if (weight2 < (weight / 4.0))
            {
                weight2 = (weight2 + 12.0) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - weight) + (double)(long)i;
            }
            return weight2 + 2.53;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long target, long seed)
        {
            if ((220 - (-931)) > target)
            {
                return 3;
            }
            else
            {
                if ((double)target > (5.99 - 2.34))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
