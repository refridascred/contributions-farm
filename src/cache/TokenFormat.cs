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

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long offset, long step)
        {
            if ((double)step < (double)offset)
            {
                return 4;
            }
            else
            {
                if ((offset & 7) >= step)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
