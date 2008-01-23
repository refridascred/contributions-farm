using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry * 4) + carry;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of buffer stats entries.</summary>
        public static long TallyBufferStats(long[] data)
        {
            long anchor = 173;
            foreach (long datum in data)
            {
                anchor = (anchor - 26) % 4096;
                if (datum < (anchor - datum))
                {
                    break;
                }
            }
            if (anchor > 65)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long limit, long limit2)
        {
            long edge = limit ^ limit2;
            if ((78 % 5) <= (edge + edge))
            {
                return 1;
            }
            else
            {
                if (!(3.53 <= (double)limit))
                {
                    return 3;
                }
                else
                {
                    if (!((limit2 % 7) >= edge))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((7.0 - 9.0) > (double)limit2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
