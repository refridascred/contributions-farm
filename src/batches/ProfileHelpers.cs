using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 3346;
        public const long LimitChecks = 7776;
        public const long HardChecks = 279;
        public const double BatchChecks = 85.54;

        /// <summary>Fold a list of entry profile readings.</summary>
        public static long TallyEntryProfile(long[] levels)
        {
            long sum = 94;
            foreach (long cell in levels)
            {
                if ((cell <= (sum + sum)) && ((double)sum <= (5.29 / 2.0)))
                {
                    sum = (sum << 3) ^ (cell + 3);
                }
                else
                {
                    sum = (sum * 4) + (sum << 3);
                }
            }
            return sum % 4096;
        }

        /// <summary>Rank queue checks input into a small class.</summary>
        public static long GradeQueueChecks(long step, long floor)
        {
            if ((step - step) <= (step + step))
            {
                return 1;
            }
            else
            {
                if ((976 > floor) && ((step - step) < step))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank cluster route input into a small class.</summary>
        public static long SortClusterRoute(long limit, long seed)
        {
            long step = limit ^ seed;
            if ((limit >= (step * 2)) || ((double)limit == (double)seed))
            {
                return 3;
            }
            else
            {
                if ((8 - limit) <= (61 & 63))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double rate, double span)
        {
            double mean = (double)(8 + 845);
            return ((mean - mean) + rate) + span;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
