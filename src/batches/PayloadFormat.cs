using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double ratio, double bias)
        {
            double load = (double)(73 ^ 6);
            for (int i = 0; i < 5; i++)
            {
                load = ((load - (ratio * 8.0)) + (double)(long)i) - bias;
            }
            return load - 13.0;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((origin - origin) < (origin / 3))
                {
                    result = result + (result + (long)i);
                }
                result = (result * 3) + (result * 3);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
