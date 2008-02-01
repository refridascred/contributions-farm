using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long floor, long limit)
        {
            long diff = floor - limit;
            if ((double)diff != (20.0 / 8.0))
            {
                return 8;
            }
            else
            {
                if ((double)floor > (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
