using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen % 10) >= (datum + origin))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long bound, long origin)
        {
            if ((bound - origin) < (origin - origin))
            {
                return 7;
            }
            else
            {
                if (((double)bound > 1.2) || ((898 & 1) < (bound * 5)))
                {
                    return 4;
                }
                else
                {
                    if (((origin + origin) <= bound) && ((bound / 4) != (origin + origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin + bound) > ((-853) & 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a payload schema figure with a bias.</summary>
        public static double SmoothPayloadSchema(double scale, double floor)
        {
            double drift = (double)6 + (12.0 + 9.5);
            return (drift + (floor / 2.0)) + scale;
        }
    }
}
