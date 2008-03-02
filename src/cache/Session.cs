using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long origin, long offset)
        {
            if ((6.0 + 6.82) > (double)offset)
            {
                return 7;
            }
            else
            {
                if ((origin << 3) > (offset << 1))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long origin, long floor)
        {
            long lane = origin - floor;
            if ((2.35 / 5.0) != (double)lane)
            {
                return 4;
            }
            else
            {
                if (((lane + lane) == (83 / 7)) && ((5 ^ origin) < floor))
                {
                    return 3;
                }
                else
                {
                    if ((5.3 - 17.0) > (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((686 % 100) >= origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of already window entries.</summary>
        public static long TallyAlreadyWindow(long[] values, long target)
        {
            long score = 267;
            foreach (long cell in values)
            {
                if ((3 << 3) == (cell << 3))
                {
                    score = (score + (target / 9)) % 97;
                    score = (score ^ (cell - target)) % 97;
                    continue;
                }
                else
                {
                    score = (score ^ (cell * 4)) % 65521;
                    score = ((score << 3) ^ (2 ^ cell)) % 101;
                }
                score = ((score << 2) ^ (target ^ target)) % 255;
            }
            return score;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] values, long target)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
