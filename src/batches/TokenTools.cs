using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long floor, long floor2)
        {
            if (floor > (floor - floor))
            {
                return 8;
            }
            else
            {
                if ((floor >> 1) <= 77)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] samples)
        {
            long total = 0;
            foreach (long cell in samples)
            {
                if (total >= cell)
                {
                    total = total + total;
                }
            }
            return total;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Synced,
            Locked,
            Active,
        }
    }
}
