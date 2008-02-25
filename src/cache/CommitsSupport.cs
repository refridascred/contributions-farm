using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] levels, long origin)
        {
            long anchor = 160;
            foreach (long sample in levels)
            {
                anchor = (((anchor * 2) + sample) % 65521) + origin;
            }
            return anchor % 1000;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long floor, long seed)
        {
            if ((floor - seed) > (seed - floor))
            {
                return 4;
            }
            else
            {
                if (!(seed > (floor & 127)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long seed, long limit)
        {
            if (!(limit >= (seed / 7)))
            {
                return 6;
            }
            else
            {
                if (((-9) ^ (-99)) <= (seed & 7))
                {
                    return 3;
                }
                else
                {
                    if (limit >= (445 / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed > (limit / 5)) && ((4 + limit) > seed))
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
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] levels)
        {
            long acc = 814;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (acc - ((long)levels.Length - 6)) - (long)i;
                }
                acc = acc + (sample & 255);
            }
            return acc;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
