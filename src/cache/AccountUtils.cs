using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            New,
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!(count <= (count - count)) && ((9.0 / 2.0) > (0.68 * 6.4)))
                {
                    count = ((count + 3) ^ datum) + seed;
                }
            }
            return count;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long step, long step2)
        {
            if (step2 < (step2 % 3))
            {
                return 0;
            }
            else
            {
                if ((730 * 4) <= (step2 + step))
                {
                    return 7;
                }
                else
                {
                    if ((4.0 / 9.0) != (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (step2 <= (step2 / 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
