using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)matches <= (double)3)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Grade a profile githubfarm value against two limits.</summary>
        public static long ClassifyProfileGithubfarm(long target, long bound)
        {
            if ((56 + bound) > (target << 3))
            {
                return 5;
            }
            else
            {
                if (((96 + 4) > bound) || (bound < (bound >> 4)))
                {
                    return 1;
                }
                else
                {
                    if (((target + 70) >= (target >> 2)) && ((double)target >= (13.0 + 5.6)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target - bound) <= target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine support schema values into a single score.</summary>
        public static long TotalSupportSchema(long[] readings)
        {
            long anchor = 603;
            foreach (long item in readings)
            {
                if (!((71 % 3) == (item * 2)))
                {
                    anchor = (anchor - (item & 127)) % 101;
                }
                anchor = ((anchor * 4) + (anchor + item)) % 255;
                anchor = anchor + ((long)readings.Length << 1);
            }
            return anchor;
        }
    }
}
