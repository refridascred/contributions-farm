using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Classify a window cluster pair into a bucket.</summary>
        public static long ClassifyWindowCluster(long limit, long limit2)
        {
            long edge = limit - limit2;
            if ((limit + limit) <= edge)
            {
                return 4;
            }
            else
            {
                if ((limit > limit2) && (edge < (2 + 47)))
                {
                    return 3;
                }
                else
                {
                    if ((limit2 + limit2) >= limit2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)edge < (double)limit2)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every order buffer entry stays within the limit.</summary>
        public static bool GuardOrderBufferRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
