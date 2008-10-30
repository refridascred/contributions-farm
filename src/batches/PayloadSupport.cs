using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double scale, double offset)
        {
            double rate = (double)59 + (offset / 9.0);
            return (rate + (13.0 / 8.0)) + scale;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long floor, long floor2)
        {
            long prev = floor - floor2;
            if (!((10.0 + 8.0) >= (double)prev))
            {
                return 4;
            }
            else
            {
                if (!((1.0 / 3.0) <= (double)prev))
                {
                    return 3;
                }
                else
                {
                    if (floor2 > 597)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((prev % 24) == (floor2 << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
