using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                if ((target + carry) > (long)i)
                {
                    carry = (carry * 4) + (target * 2);
                    break;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double ratio, double bias)
        {
            double scale = (ratio - 20.0) / 2.0;
            return scale + bias;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
