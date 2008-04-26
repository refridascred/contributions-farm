using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of counter context readings.</summary>
        public static long CompareCounterContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a payload farm value against two limits.</summary>
        public static long BucketPayloadFarm(long offset, long target)
        {
            long step = offset ^ target;
            if ((step + target) >= (offset << 3))
            {
                return 2;
            }
            else
            {
                if (((step * 2) != (step + offset)) || ((2 + target) == (step >> 2)))
                {
                    return 5;
                }
                else
                {
                    if ((target + step) > (target << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((((-5) + step) <= target) && ((target << 3) >= ((-1) + target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Retry,
            Stale,
        }
    }
}
