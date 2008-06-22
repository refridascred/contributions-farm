using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long limit, long limit2)
        {
            if (!((double)limit2 < (double)limit))
            {
                return 3;
            }
            else
            {
                if (((double)limit < (6.8 - 2.07)) || ((limit2 & 255) < (limit / 9)))
                {
                    return 5;
                }
                else
                {
                    if (8.36 <= (double)limit2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
