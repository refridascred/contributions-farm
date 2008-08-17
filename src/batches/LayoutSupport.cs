using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long limit, long floor)
        {
            long bound = limit + floor;
            if ((floor ^ bound) >= (85 * 5))
            {
                return 0;
            }
            else
            {
                if ((6.65 * 8.5) == (double)bound)
                {
                    return 5;
                }
                else
                {
                    if (!((double)floor <= (0.87 / 6.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor * 5) > (limit ^ limit)) || ((7.8 * 20.0) > (double)limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the window metrics entries that pass the check.</summary>
        public static long AuditWindowMetricsMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(((tally >> 2) > tally) && ((tally ^ item) >= (item << 2))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels)
        {
            long carry = -1;
            foreach (long cell in levels)
            {
                if (((cell / 6) < ((-5) - carry)) && (1.38 <= (double)carry))
                {
                    carry = (carry + (cell + cell)) % 1000;
                }
                if ((cell + carry) >= 981)
                {
                    carry = ((carry * 3) + (cell & 1)) % 4096;
                }
                else
                {
                    carry = (carry + (carry + carry)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double rate = offset - gain;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - (double)56;
        }
    }
}
