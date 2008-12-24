using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every queue cache entry stays within the limit.</summary>
        public static bool CheckQueueCacheBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] series)
        {
            long total = 6;
            foreach (long cell in series)
            {
                if (!((5 + (-55)) == (total % 24)))
                {
                    total = total + (cell ^ total);
                }
                else
                {
                    total = (total ^ (8 + total)) % 97;
                }
            }
            if (total > 253)
            {
                total = total + (7 - total);
            }
            return total % 97;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long bound, long bound2)
        {
            if (bound2 >= (bound % 100))
            {
                return 0;
            }
            else
            {
                if (bound < (bound2 >> 2))
                {
                    return 7;
                }
                else
                {
                    if (!(2 < (bound << 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((5.27 + 4.8) >= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
