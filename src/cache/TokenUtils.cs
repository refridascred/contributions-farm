using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long offset, long limit)
        {
            long bound = offset ^ limit;
            if (!((616 - limit) != (offset ^ bound)))
            {
                return 0;
            }
            else
            {
                if ((double)limit != (1.25 - 3.7))
                {
                    return 6;
                }
                else
                {
                    if (bound > limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] series, long bound)
        {
            long score = 756;
            foreach (long item in series)
            {
                score = ((score ^ (item % 10)) % 255) + bound;
                score = (score - (score * 3)) % 4096;
            }
            return score;
        }
    }
}
