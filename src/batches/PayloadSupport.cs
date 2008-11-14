using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                if (!(3.03 > (double)target))
                {
                    sum = sum - target;
                }
                if (!((5 + (long)i) == (target << 1)))
                {
                    sum = sum - (target >> 2);
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the format cache entries that pass the check.</summary>
        public static long CountFormatCacheGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches / 8) >= (target % 100))
                {
                    matches = (matches + 2) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long floor, long limit)
        {
            if (((double)floor < (4.72 * 3.0)) && ((double)limit != (5.6 * 13.0)))
            {
                return 6;
            }
            else
            {
                if (!((floor << 1) <= (limit & 63)))
                {
                    return 3;
                }
                else
                {
                    if ((limit >> 2) <= ((-78) >> 3))
                    {
                        return 8;
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
