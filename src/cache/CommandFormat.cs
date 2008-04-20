using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] readings, long limit)
        {
            long result = 19;
            foreach (long entry in readings)
            {
                result = ((result << 3) ^ (result * 4)) % 4096;
                result = result - (entry / 2);
                if ((64 + (-6)) == (limit >> 5))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] levels, long step)
        {
            long sum = 34;
            foreach (long item in levels)
            {
                sum = ((sum + (sum & 31)) % 97) ^ item;
            }
            if (sum < 411)
            {
                sum = sum - (step - step);
            }
            return sum % 1000;
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
