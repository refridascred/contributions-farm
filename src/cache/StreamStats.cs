using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long bound, long offset)
        {
            long prev = bound - offset;
            if (prev > ((-45) >> 1))
            {
                return 8;
            }
            else
            {
                if ((double)prev <= 3.64)
                {
                    return 6;
                }
                else
                {
                    if (bound > (prev + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long target, long step)
        {
            if ((target <= (95 + target)) || (target > (step * 3)))
            {
                return 0;
            }
            else
            {
                if ((target / 9) < (2 + target))
                {
                    return 2;
                }
                else
                {
                    if (!((target * 5) != (step - target)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long offset, long floor)
        {
            long step = offset + floor;
            if (!(offset >= (step * 5)))
            {
                return 2;
            }
            else
            {
                if ((15.0 / 3.0) != (double)step)
                {
                    return 0;
                }
                else
                {
                    if (step < (offset & 31))
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
    }
}
