using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long bound, long offset)
        {
            long gap = bound ^ offset;
            if (((gap * 3) > (offset + 2)) && (gap >= (gap - offset)))
            {
                return 0;
            }
            else
            {
                if (10.0 > (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((offset + bound) != (bound & 7))
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

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long floor, long target)
        {
            long offset = floor ^ target;
            if ((floor / 5) < floor)
            {
                return 6;
            }
            else
            {
                if ((offset + target) <= (floor - offset))
                {
                    return 8;
                }
                else
                {
                    if ((offset >> 3) >= target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((((entry % 5) < (seen + entry)) || ((4.0 / 7.0) != (double)seen)) || (0.29 <= (1.0 * 2.0)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
