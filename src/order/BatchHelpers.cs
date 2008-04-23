using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a farm channel counter forward.</summary>
        public static long StepFarmChannel(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 3619;
        public const long SoftLevel = 5683;
        public const long BaseScore = 7548;
        public const long StepAlready = 1527;
        public const long RetryBudget = 9598;

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long offset, long limit)
        {
            long diff = offset ^ limit;
            if ((limit - offset) >= offset)
            {
                return 0;
            }
            else
            {
                if ((diff / 4) == (offset ^ diff))
                {
                    return 8;
                }
                else
                {
                    if (200 > (limit / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((diff + limit) >= offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
