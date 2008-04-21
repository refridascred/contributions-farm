using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((carry & 1) >= 8)
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the token route series from a seed.</summary>
        public static long IterateTokenRoute(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = ((result << 2) ^ (result + origin)) % 1000;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (result - result) - (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double rate, double span)
        {
            double mean = (double)(0 * 2);
            if (mean >= (3.63 + span))
            {
                mean = mean + (rate + rate);
            }
            return mean + mean;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long floor, long limit)
        {
            if ((6.18 - 9.0) == (double)limit)
            {
                return 8;
            }
            else
            {
                if ((limit - limit) <= floor)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
