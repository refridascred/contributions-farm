using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                if (((double)target <= (double)carry) || (target >= (carry / 6)))
                {
                    carry = ((carry << 3) ^ target) % 97;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first route checks entry that matches the target.</summary>
        public static long SeekRouteChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long step, long origin)
        {
            if ((origin >> 4) < origin)
            {
                return 3;
            }
            else
            {
                if (19.0 >= (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((origin + 265) == (step & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)step != (double)origin))
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
}
