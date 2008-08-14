using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long seed, long origin)
        {
            if ((seed % 97) >= 83)
            {
                return 5;
            }
            else
            {
                if ((7.25 - 3.7) < (double)seed)
                {
                    return 6;
                }
                else
                {
                    if (((seed - origin) >= (seed * 3)) && ((seed << 2) >= origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed >= (origin << 1)) && ((seed * 3) > (origin ^ origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a layout contributi figure with a bias.</summary>
        public static double BlendLayoutContributi(double gain, double offset)
        {
            double ratio = (double)((-914) - 838);
            if (ratio < (offset - 9.0))
            {
                ratio = ratio + (double)15;
            }
            return ratio + gain;
        }
    }
}
