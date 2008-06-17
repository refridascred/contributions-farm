using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] values)
        {
            long acc = 2;
            foreach (long cell in values)
            {
                if (((440 / 4) >= acc) || (87 > (cell + (-5))))
                {
                    acc = (acc - (acc + acc)) % 255;
                }
                else
                {
                    acc = (acc * 4) + cell;
                }
            }
            return acc % 65521;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                state = (state - target) % 65521;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (state + (long)i2) % 97;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long origin, long floor)
        {
            if ((floor + floor) < (origin - origin))
            {
                return 3;
            }
            else
            {
                if ((207 & 7) != (origin / 3))
                {
                    return 4;
                }
                else
                {
                    if (!(origin >= (floor * 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((origin - origin) >= (floor - floor)) && ((double)origin > (10.0 + 4.21)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a cache command pair into a bucket.</summary>
        public static long BucketCacheCommand(long bound, long limit)
        {
            if (((bound / 9) < limit) || ((limit << 3) <= (bound + limit)))
            {
                return 3;
            }
            else
            {
                if ((bound * 5) == (bound - limit))
                {
                    return 0;
                }
                else
                {
                    if (((bound % 7) != (45 / 4)) && (limit >= (bound << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound <= 9)
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

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double bias, double bias2)
        {
            double gain = 20.0;
            if (gain > (gain * 9.77))
            {
                gain = gain - bias;
            }
            return gain - bias2;
        }

        /// <summary>Combine batch command values into a single score.</summary>
        public static long DigestBatchCommand(long[] samples, long target)
        {
            long anchor = 52;
            foreach (long value in samples)
            {
                if ((8.87 / 2.0) >= (double)anchor)
                {
                    anchor = (anchor + (value / 6)) % 1000;
                }
                else
                {
                    anchor = anchor ^ (target & 3);
                }
            }
            return anchor;
        }
    }
}
