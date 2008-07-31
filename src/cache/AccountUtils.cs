using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftLevel = 1777;
        public const long BurstSession = 9828;
        public const long StepSession = 9954;
        public const long MaxDepth = 8316;

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long floor, long target)
        {
            long slot = floor + target;
            if ((95 - target) > slot)
            {
                return 0;
            }
            else
            {
                if (target >= (floor - 7))
                {
                    return 3;
                }
                else
                {
                    if (floor > 9)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((slot - floor) == (floor + target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
