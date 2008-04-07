using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long origin, long step)
        {
            if (2.19 > (double)step)
            {
                return 5;
            }
            else
            {
                if ((step - step) >= (step + origin))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long bound, long limit)
        {
            long diff = bound ^ limit;
            if (limit >= diff)
            {
                return 4;
            }
            else
            {
                if (((double)limit >= 8.58) || ((1 & 255) >= (bound % 60)))
                {
                    return 3;
                }
                else
                {
                    if (((-583) / 6) < (bound + diff))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)diff < (7.4 - 6.4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Ready,
            Done,
            Paused,
        }
    }
}
