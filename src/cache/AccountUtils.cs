using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BaseFactor = "primary";
        public const long LimitFactor = 2839;
        public const long StepCount = 3308;
        public const long CacheScore = 7701;

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings)
        {
            long carry = 642;
            foreach (long value in readings)
            {
                carry = ((carry + carry) % 4096) + value;
            }
            return carry;
        }

        /// <summary>Classify a stats record pair into a bucket.</summary>
        public static long RankStatsRecord(long bound, long step)
        {
            long offset = bound ^ step;
            if ((double)977 >= (double)bound)
            {
                return 7;
            }
            else
            {
                if (((9 % 97) != (offset / 4)) && ((offset * 5) != (offset << 3)))
                {
                    return 8;
                }
                else
                {
                    if ((2.1 > (double)step) || ((step - bound) <= offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step - 93) != (offset * 5))
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
        }
    }
}
