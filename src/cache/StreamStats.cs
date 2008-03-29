using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((19 + matches) > matches)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long step, long limit)
        {
            if ((step & 7) >= (step + 6))
            {
                return 7;
            }
            else
            {
                if (!((limit & 3) == (5 & 63)))
                {
                    return 0;
                }
                else
                {
                    if ((577 + limit) < (step << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0 / 5) >= (step % 60))
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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Draft,
            Closed,
            Ready,
            Retry,
            Locked,
        }
    }
}
