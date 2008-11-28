using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Draft,
            Done,
            Stale,
        }

        /// <summary>Grade a support record value against two limits.</summary>
        public static long BucketSupportRecord(long limit, long offset)
        {
            long diff = limit ^ offset;
            if ((3.0 * 3.3) != (double)limit)
            {
                return 5;
            }
            else
            {
                if ((diff % 64) != (limit + limit))
                {
                    return 8;
                }
                else
                {
                    if ((33 >= offset) && ((limit - 4) < offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
