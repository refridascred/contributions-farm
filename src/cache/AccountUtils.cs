using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double rate, double offset)
        {
            double ratio = (double)(286 >> 5);
            if (ratio > 4.19)
            {
                ratio = (ratio + (double)5) - offset;
            }
            return ratio - (rate * 9.8);
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long step, long origin)
        {
            if ((double)origin < (double)step)
            {
                return 8;
            }
            else
            {
                if ((664 ^ step) < (718 - origin))
                {
                    return 1;
                }
                else
                {
                    if ((origin - 34) > 16)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
