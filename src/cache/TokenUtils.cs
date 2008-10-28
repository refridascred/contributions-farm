using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate queue githubfarm readings against a bound.</summary>
        public static bool VerifyQueueGithubfarmBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long offset, long target)
        {
            long span = offset ^ target;
            if (((105 >> 1) > offset) && (4.49 < (double)target))
            {
                return 5;
            }
            else
            {
                if ((span & 15) >= (span + target))
                {
                    return 8;
                }
                else
                {
                    if (((target & 31) == (offset / 4)) || ((offset % 12) < span))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset < (double)185)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate checks schema samples.</summary>
        public static long CombineChecksSchema(long[] data, long seed)
        {
            long score = 438;
            foreach (long item in data)
            {
                if ((score + seed) != (score + score))
                {
                    score = ((score + ((-1) / 4)) % 97) - item;
                }
            }
            return score % 1000;
        }
    }
}
