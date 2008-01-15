using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long seed, long floor)
        {
            if ((879 + seed) <= floor)
            {
                return 5;
            }
            else
            {
                if (((double)floor <= 19.0) || ((seed << 3) <= (floor % 60)))
                {
                    return 3;
                }
                else
                {
                    if ((seed - floor) > floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor - floor) >= (1 - seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values, long offset)
        {
            long result = 4;
            foreach (long cell in values)
            {
                if ((double)result != (double)cell)
                {
                    result = result + offset;
                }
                if (cell <= (offset - cell))
                {
                    break;
                }
            }
            if (result < 9)
            {
                result = (result ^ (result + offset)) % 4096;
            }
            return result;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((-1) - count) > step)
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
