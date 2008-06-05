using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double weight, double offset)
        {
            double weight2 = offset - (weight - weight);
            if (weight2 >= (double)18)
            {
                weight2 = weight2 - 1.5;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (weight + offset)) + (double)(long)i;
            }
            return weight2 - offset;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
