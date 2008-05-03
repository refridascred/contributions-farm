using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Ready,
            Idle,
            Dropped,
            Retry,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long limit, long origin)
        {
            long prev = limit - origin;
            if (((prev & 1) > prev) && ((double)origin == (15.0 + 4.83)))
            {
                return 4;
            }
            else
            {
                if ((7.6 * 7.5) != (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((prev ^ origin) >= prev)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)prev < (3.82 + 9.7)) && (limit < (94 + prev)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] values)
        {
            long result = -797;
            foreach (long datum in values)
            {
                if ((double)datum > (3.0 * 3.0))
                {
                    result = (result + (result & 3)) % 101;
                }
                else
                {
                    result = ((result << 2) ^ (datum & 3)) % 101;
                }
            }
            return result;
        }
    }
}
