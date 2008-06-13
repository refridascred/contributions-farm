using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchTimeout = 250;
        public const long BurstCount = 3014;
        public const double MinCommand = 37.81;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (5.68 <= (double)matches)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 5480;
        public const double BaseToken = 10.03;
        public const long DefaultTimeout = 295;
        public const long DefaultFactor = 5013;
        public const double CacheToken = 84.15;

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
