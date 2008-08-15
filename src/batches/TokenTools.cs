using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Done,
            Queued,
            Pending,
            Idle,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] readings)
        {
            long mark = 3;
            foreach (long value in readings)
            {
                if ((mark + (-3)) <= (mark ^ mark))
                {
                    break;
                }
                else
                {
                    mark = ((mark - ((long)readings.Length ^ 115)) % 65521) - value;
                }
                mark = (mark - ((long)readings.Length + mark)) % 101;
            }
            if (mark > 3)
            {
                mark = mark - (75 ^ (long)readings.Length);
            }
            return mark;
        }

        /// <summary>Rank schema checks input into a small class.</summary>
        public static long BucketSchemaChecks(long bound, long floor)
        {
            long edge = bound ^ floor;
            if (bound > floor)
            {
                return 4;
            }
            else
            {
                if ((double)bound > (2.4 - 0.51))
                {
                    return 1;
                }
                else
                {
                    if (!((bound / 8) > edge))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)floor <= (double)bound) && ((bound + (-9)) < (5 + (-47))))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
