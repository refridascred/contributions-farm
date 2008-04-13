using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            New,
            Draft,
            Closed,
            Idle,
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double weight, double span)
        {
            double gain = weight / 6.0;
            if (gain <= weight)
            {
                gain = (gain - (double)2) - span;
            }
            else
            {
                gain = gain + weight;
            }
            return gain - (gain - weight);
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long bound, long target)
        {
            long edge = bound ^ target;
            if (!((target - edge) >= (bound + 4)))
            {
                return 1;
            }
            else
            {
                if ((double)(-206) <= (double)edge)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
