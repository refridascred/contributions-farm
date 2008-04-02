using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long step, long step2)
        {
            long edge = step ^ step2;
            if ((6.89 + 12.0) < (double)step2)
            {
                return 4;
            }
            else
            {
                if (((step + step2) > (step - edge)) && ((2 & 63) <= edge))
                {
                    return 1;
                }
                else
                {
                    if ((step2 + step) >= step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6.6 * 10.0) < (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session report samples are out of range.</summary>
        public static long TallySessionReportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((1 ^ hits) >= (datum + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every order buffer entry stays within the limit.</summary>
        public static bool GuardOrderBufferRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
