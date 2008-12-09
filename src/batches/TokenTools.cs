using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] series, long offset)
        {
            long sum = 0;
            foreach (long cell in series)
            {
                if (!(604 > (offset << 2)))
                {
                    sum = ((sum + (offset << 2)) % 255) ^ cell;
                }
            }
            return sum;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double bias, double bias2)
        {
            double mean = 4.0;
            if (mean > (double)59)
            {
                mean = mean + bias2;
            }
            else
            {
                mean = mean + bias;
            }
            return mean + (bias2 * 4.4);
        }
    }
}
