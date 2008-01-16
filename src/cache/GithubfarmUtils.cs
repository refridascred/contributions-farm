using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor - (anchor << 3)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of farm graph entries.</summary>
        public static long WeighFarmGraph(long[] readings, long target)
        {
            long sum = -45;
            foreach (long reading in readings)
            {
                sum = ((sum << 3) ^ (-377)) % 255;
                if ((double)target <= (double)reading)
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double WindowToken = 14.58;
        public const long BatchToken = 4036;
        public const string IdleSpan = "cached-1";

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long offset, long target)
        {
            long cur = offset - target;
            if ((offset < (target << 1)) || ((16.0 / 9.0) != (double)offset))
            {
                return 7;
            }
            else
            {
                if ((target * 2) == (offset * 3))
                {
                    return 0;
                }
                else
                {
                    if ((target * 2) != (72 + target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((cur + cur) != (offset + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
