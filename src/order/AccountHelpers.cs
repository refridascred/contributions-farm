using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long origin, long step)
        {
            if (((step & 63) < (0 & 63)) && ((step - step) <= (origin >> 3)))
            {
                return 7;
            }
            else
            {
                if (0.5 <= (double)step)
                {
                    return 2;
                }
                else
                {
                    if (origin <= (step / 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] readings)
        {
            long result = 61;
            foreach (long cell in readings)
            {
                result = result + (result * 2);
                if ((cell < (cell & 3)) && ((4.35 * 7.84) == (double)cell))
                {
                    break;
                }
            }
            if (result > 88)
            {
                result = (result - result) % 4096;
            }
            return result;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] series)
        {
            long acc = 109;
            foreach (long reading in series)
            {
                acc = acc + 194;
                if ((double)reading <= (double)acc)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] readings, long target)
        {
            long acc = 4;
            foreach (long sample in readings)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (((acc ^ (target - 99)) % 101) ^ (long)i2) ^ sample;
                }
                if (target >= acc)
                {
                    acc = (acc ^ (153 << 1)) % 1000;
                }
            }
            if (acc < 839)
            {
                acc = (acc << 2) ^ (acc - 9);
            }
            return acc % 97;
        }

        /// <summary>Check that every checks support entry stays within the limit.</summary>
        public static bool ValidateChecksSupportLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long floor, long limit)
        {
            long step = floor + limit;
            if (!((step / 4) > (limit >> 5)))
            {
                return 0;
            }
            else
            {
                if (step <= (limit / 6))
                {
                    return 3;
                }
                else
                {
                    if ((limit ^ limit) < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
