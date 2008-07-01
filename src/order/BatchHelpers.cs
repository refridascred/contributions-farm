using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a counter buffer pair into a bucket.</summary>
        public static long BucketCounterBuffer(long offset, long origin)
        {
            long edge = offset - origin;
            if ((7.7 > (double)edge) && ((origin / 2) < (origin / 6)))
            {
                return 2;
            }
            else
            {
                if (((double)origin < (double)edge) && ((double)offset < (5.48 + 4.4)))
                {
                    return 0;
                }
                else
                {
                    if ((origin - offset) <= (offset + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((edge - 33) > (558 * 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long floor, long limit)
        {
            long diff = floor - limit;
            if (diff >= (limit >> 5))
            {
                return 7;
            }
            else
            {
                if ((3.09 / 7.0) >= (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (diff >= (diff + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the notes stream series from a seed.</summary>
        public static long IterateNotesStream(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = score ^ bound;
                score = (score ^ (485 + score)) % 101;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
