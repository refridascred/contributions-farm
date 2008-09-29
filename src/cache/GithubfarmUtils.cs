using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank token payload input into a small class.</summary>
        public static long BucketTokenPayload(long seed, long target)
        {
            if ((8.2 / 9.0) == (double)target)
            {
                return 5;
            }
            else
            {
                if ((seed >= (target / 9)) && ((target + seed) != (87 >> 3)))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed > (1.4 / 8.0)) || (target <= (target << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((target & 127) == (target / 5)))
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

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] data, long bound)
        {
            long score = 478;
            foreach (long value in data)
            {
                if ((double)score < (4.58 / 9.0))
                {
                    score = score + (bound ^ value);
                }
                if ((5.5 / 9.0) >= (double)value)
                {
                    break;
                }
            }
            if (score > 999)
            {
                score = (score << 2) ^ (score / 4);
            }
            return score;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            Dropped,
            Draft,
            Active,
        }
    }
}
