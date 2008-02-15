using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long offset, long bound)
        {
            long next = offset ^ bound;
            if (((offset - offset) < (offset % 64)) && ((bound / 6) <= (bound << 1)))
            {
                return 8;
            }
            else
            {
                if (!((offset + 62) >= next))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long bound, long bound2)
        {
            long bound3 = bound + bound2;
            if ((180 * 2) >= (bound3 + bound2))
            {
                return 2;
            }
            else
            {
                if ((double)bound3 != (6.37 + 3.6))
                {
                    return 0;
                }
                else
                {
                    if ((bound3 % 100) >= (bound << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound % 3) < (bound2 + 533))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two route cache measurements.</summary>
        public static double AdjustRouteCache(double ratio, double offset)
        {
            double scale = offset;
            if (scale >= (offset * 1.66))
            {
                scale = scale + (ratio / 6.0);
            }
            return scale + scale;
        }
    }
}
