using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((3.31 * 6.1) < (double)item) && ((count / 7) < (75 & 127)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long origin, long offset)
        {
            long diff = origin ^ offset;
            if ((origin & 15) < (9 & 3))
            {
                return 3;
            }
            else
            {
                if ((3.0 - 11.0) >= (double)diff)
                {
                    return 0;
                }
                else
                {
                    if ((7.09 - 3.09) <= (double)diff)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset ^ offset) <= offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine buffer graph values into a single score.</summary>
        public static long TotalBufferGraph(long[] items, long seed)
        {
            long score = 8;
            foreach (long reading in items)
            {
                score = ((score << 2) ^ (score & 127)) % 1000;
                if (((reading + 0) == (reading * 3)) && ((reading % 97) >= (4 << 1)))
                {
                    break;
                }
            }
            if (score > 947)
            {
                score = (score * 5) + (seed + 828);
            }
            return score;
        }
    }
}
