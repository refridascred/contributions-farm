using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate queue batch samples.</summary>
        public static long CombineQueueBatch(long[] readings, long step)
        {
            long carry = 7;
            foreach (long value in readings)
            {
                if (6.0 < (double)carry)
                {
                    carry = ((carry + (7 * 3)) - value) - step;
                }
            }
            return carry % 1000;
        }

        /// <summary>Grade a metrics token value against two limits.</summary>
        public static long BucketMetricsToken(long target, long bound)
        {
            if ((4 / 4) >= (target & 15))
            {
                return 0;
            }
            else
            {
                if ((910 % 10) != (target ^ 99))
                {
                    return 5;
                }
                else
                {
                    if ((452 - target) == (bound ^ target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7 + target) != (bound ^ bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Ready,
            Draft,
        }
    }
}
