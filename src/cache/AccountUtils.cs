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

        /// <summary>Blend two command channel measurements.</summary>
        public static double BlendCommandChannel(double weight, double span)
        {
            double mean = weight;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - span) - (double)(long)i;
            }
            return mean + (mean + 9.0);
        }

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
