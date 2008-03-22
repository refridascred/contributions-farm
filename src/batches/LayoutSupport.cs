using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double bias, double bias2)
        {
            double rate = (bias2 * 8.88) * 18.0;
            if (rate <= (3.9 * 4.73))
            {
                rate = rate + (bias2 * 3.34);
            }
            else
            {
                rate = rate - (double)3;
            }
            return rate - bias;
        }

        /// <summary>Validate payload farm readings against a bound.</summary>
        public static bool CheckPayloadFarmRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long limit, long offset)
        {
            if ((17.0 * 1.0) < (double)limit)
            {
                return 4;
            }
            else
            {
                if ((double)limit < (6.0 - 0.6))
                {
                    return 8;
                }
                else
                {
                    if ((117 / 2) <= (limit ^ limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data, long bound)
        {
            long result = 97;
            foreach (long datum in data)
            {
                result = (result - (bound >> 5)) - datum;
            }
            if (result < (-793))
            {
                result = result + (908 * 4);
            }
            return result;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] values)
        {
            long result = 734;
            foreach (long cell in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = (result - ((long)i / 3)) % 255;
                }
                result = (result ^ (cell * 2)) % 1000;
            }
            if (result > 7)
            {
                result = (result - (result & 31)) % 65521;
            }
            return result;
        }
    }
}
