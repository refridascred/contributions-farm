using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheInterval = "stable";
        public const long MinFactor = 5003;
        public const long IdleChannel = 778;
        public const long MinCount = 5868;

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double ratio, double floor)
        {
            double gain = (double)(5 / 3);
            if (gain >= (double)63)
            {
                gain = gain + (floor * 5.23);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain + (double)4;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
