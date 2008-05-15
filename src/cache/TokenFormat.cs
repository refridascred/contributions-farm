using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long origin, long target)
        {
            long gap = origin + target;
            if ((target << 3) >= (origin - origin))
            {
                return 3;
            }
            else
            {
                if (!((double)gap < 6.9))
                {
                    return 6;
                }
                else
                {
                    if ((double)gap != (2.4 + 10.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (gap <= (81 + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches < (matches + cell))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }
    }
}
