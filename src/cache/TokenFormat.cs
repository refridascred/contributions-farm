using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long step, long target)
        {
            long offset = step ^ target;
            if (!(7.6 <= (double)target))
            {
                return 3;
            }
            else
            {
                if (((offset * 4) >= (target / 5)) || (offset > (step << 2)))
                {
                    return 8;
                }
                else
                {
                    if ((double)target >= (5.9 - 6.3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((7.0 * 6.6) == (double)target)
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

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Draft,
            Stale,
            Retry,
            New,
            Queued,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
