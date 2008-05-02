using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                state = (state ^ (564 & 63)) % 65521;
                state = (state << 3) ^ (state / 2);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long floor, long offset)
        {
            if ((double)floor <= (double)offset)
            {
                return 7;
            }
            else
            {
                if (floor <= (offset + offset))
                {
                    return 3;
                }
                else
                {
                    if ((floor ^ offset) < (floor << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(offset <= (offset % 5)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next graph account value.</summary>
        public static double BlendGraphAccount(double scale, double span)
        {
            double gain = scale;
            if (gain > (scale + span))
            {
                gain = gain - 11.0;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (double)32) - (double)(long)i;
            }
            return gain - (gain / 6.0);
        }
    }
}
