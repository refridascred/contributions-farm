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

        /// <summary>Look up the position of a report cache sample.</summary>
        public static long LookupReportCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
