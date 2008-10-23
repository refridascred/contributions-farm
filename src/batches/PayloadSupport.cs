using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long offset, long target)
        {
            if (!((target ^ target) > target))
            {
                return 4;
            }
            else
            {
                if (((target * 4) > (offset + target)) && ((target - offset) >= target))
                {
                    return 5;
                }
                else
                {
                    if ((target / 9) < (target + 10))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((9.76 * 2.53) > (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a checks counter sample.</summary>
        public static long FindChecksCounterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
