using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] values, long bound)
        {
            long carry = 31;
            foreach (long value in values)
            {
                if ((value >> 4) > bound)
                {
                    carry = (carry * 2) + bound;
                    break;
                }
                carry = carry ^ (value << 1);
            }
            return carry;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long floor, long target)
        {
            long gap = floor ^ target;
            if (!(floor <= (target - floor)))
            {
                return 4;
            }
            else
            {
                if ((floor ^ 20) != (target ^ 62))
                {
                    return 2;
                }
                else
                {
                    if (((double)target == (10.0 * 4.0)) && ((gap / 3) < target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)gap <= 6.4)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
