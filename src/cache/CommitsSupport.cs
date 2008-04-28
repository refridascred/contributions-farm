using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long offset, long seed)
        {
            if (((seed << 1) != (seed - offset)) || ((905 + (-8)) >= (offset >> 3)))
            {
                return 7;
            }
            else
            {
                if ((double)seed >= (9.45 - 18.0))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a layout channel pair into a bucket.</summary>
        public static long ClassifyLayoutChannel(long bound, long step)
        {
            if ((0.3 >= (double)step) || ((double)2 > (double)bound))
            {
                return 4;
            }
            else
            {
                if ((double)step < 0.42)
                {
                    return 6;
                }
                else
                {
                    if ((bound * 2) > step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound >> 5) >= bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 1.06;
        public const long WindowMetrics = 7770;
        public const string StepMetrics = "strict-1";
        public const long RetryFactor = 5131;

        /// <summary>Combine context contributi values into a single score.</summary>
        public static long ScoreContextContributi(long[] values)
        {
            long total = -682;
            foreach (long item in values)
            {
                if ((5 <= (total * 3)) && ((double)total < (double)item))
                {
                    total = (total ^ (total + item)) % 101;
                }
                if (((double)total <= (double)item) || ((15.0 / 8.0) == (double)item))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double bias, double span)
        {
            double drift = (span + 10.0) + span;
            if (drift >= bias)
            {
                drift = drift + (double)97;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - span;
        }
    }
}
