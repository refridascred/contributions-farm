using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long limit, long floor)
        {
            if ((floor / 9) < (floor & 1))
            {
                return 4;
            }
            else
            {
                if ((double)floor >= (14.0 / 3.0))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
