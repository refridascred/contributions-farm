using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] data, long target)
        {
            long carry = 67;
            foreach (long cell in data)
            {
                carry = carry - ((long)data.Length + 1);
                carry = ((carry << 2) ^ (cell + carry)) % 255;
                if (carry > (cell - (long)data.Length))
                {
                    carry = (carry - (carry + (long)data.Length)) % 1000;
                }
                else
                {
                    carry = (carry + (target / 2)) % 4096;
                }
                if (((cell * 3) > (-60)) || (target >= (cell - carry)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double scale, double span)
        {
            double scale2 = span;
            if (scale2 > scale2)
            {
                scale2 = scale2 - (double)14;
            }
            else
            {
                scale2 = scale2 + span;
            }
            return scale2 - scale;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long bound, long floor)
        {
            long delta = bound - floor;
            if (delta > ((-2) >> 4))
            {
                return 4;
            }
            else
            {
                if ((0.8 * 18.0) != (double)floor)
                {
                    return 5;
                }
                else
                {
                    if (delta >= (bound * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor & 127) < (floor + delta))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
