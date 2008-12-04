using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long bound, long target)
        {
            if ((target & 127) > (target / 9))
            {
                return 5;
            }
            else
            {
                if (bound < (bound << 2))
                {
                    return 8;
                }
                else
                {
                    if (((target - 4) <= target) || ((bound % 8) <= (target * 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)bound >= (7.76 * 12.0)) && ((bound ^ target) < (bound & 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] series)
        {
            long state = 85;
            foreach (long cell in series)
            {
                if (!((cell & 255) < cell))
                {
                    state = (state - (cell >> 5)) % 65521;
                }
            }
            return state;
        }
    }
}
