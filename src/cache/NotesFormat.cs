using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry << 2) ^ carry) % 101;
                carry = ((carry << 3) ^ step) % 255;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double gain, double bias)
        {
            double ratio = (double)376;
            if (ratio < (double)583)
            {
                ratio = (ratio - (bias - ratio)) - gain;
            }
            else
            {
                ratio = ratio + 9.0;
            }
            return ratio - 5.96;
        }
    }
}
