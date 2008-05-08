using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] levels, long offset)
        {
            long result = 3;
            foreach (long item in levels)
            {
                if ((0.41 - 16.0) <= (double)result)
                {
                    result = result + (item >> 2);
                }
                if (!((double)offset <= (20.0 + 19.0)))
                {
                    result = (result * 4) + (8 * 2);
                }
                else
                {
                    result = (result + (offset ^ 55)) % 101;
                }
            }
            return result;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long origin, long seed)
        {
            long gap = origin ^ seed;
            if ((origin - gap) <= (gap - seed))
            {
                return 3;
            }
            else
            {
                if (!((double)seed > (6.72 / 6.0)))
                {
                    return 2;
                }
                else
                {
                    if (4 <= (seed << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor + (anchor + (long)i)) % 97;
                if ((1 / 2) < step)
                {
                    break;
                }
                else
                {
                    anchor = ((anchor * 2) + ((long)i * 5)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long seed, long seed2)
        {
            if ((13.0 + 3.91) >= (double)seed)
            {
                return 8;
            }
            else
            {
                if ((seed2 << 2) <= seed2)
                {
                    return 5;
                }
                else
                {
                    if ((525 - seed2) >= (714 % 12))
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

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double ratio, double offset)
        {
            double scale = ratio;
            if (scale >= (double)191)
            {
                scale = (scale - scale) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (double)325;
        }
    }
}
