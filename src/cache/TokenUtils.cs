using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double bias = weight - (double)7;
            return bias - (span + bias);
        }

        /// <summary>Roll a stream order counter forward.</summary>
        public static long RollStreamOrder(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                long diff = ((-8) % 60) - ((long)i + 91);
                if ((diff < (30 + 65)) || ((double)diff <= (1.08 - 9.2)))
                {
                    diff = ((diff * 3) + diff) % 97;
                }
                anchor = (anchor + (floor & 1)) % 101;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
