using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long floor, long bound)
        {
            long next = floor ^ bound;
            if ((double)next > (8.4 - 0.52))
            {
                return 8;
            }
            else
            {
                if (((bound * 2) >= (bound + floor)) || ((double)bound < 2.0))
                {
                    return 6;
                }
                else
                {
                    if ((next / 3) != (0 - 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor >> 3) <= (next / 4)) || ((floor % 97) >= bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double scale, double bias)
        {
            double ratio = (double)(3 - 24);
            if (ratio >= scale)
            {
                ratio = ratio - (5.46 + bias);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Digest a series of buffer entry entries.</summary>
        public static long DigestBufferEntry(long[] series, long limit)
        {
            long state = -3;
            foreach (long item in series)
            {
                state = (state ^ limit) % 97;
                state = ((state * 4) + (limit + limit)) % 1000;
                if ((6.51 - 9.7) >= (double)limit)
                {
                    state = ((state << 3) ^ (state + item)) % 255;
                }
            }
            return state;
        }
    }
}
