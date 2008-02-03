using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long seed, long origin)
        {
            if ((double)seed >= (7.0 + 11.0))
            {
                return 6;
            }
            else
            {
                if ((origin % 100) > (5 - seed))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin < (4.85 / 8.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed >= 3.8)
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
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long step, long limit)
        {
            long prev = step ^ limit;
            if ((6.58 + 5.84) > (double)prev)
            {
                return 1;
            }
            else
            {
                if (prev > (prev << 3))
                {
                    return 7;
                }
                else
                {
                    if (8 < (limit + prev))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
