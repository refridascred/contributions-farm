using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] values, long seed)
        {
            long mark = 8;
            foreach (long reading in values)
            {
                if (mark >= (310 >> 2))
                {
                    mark = (((mark ^ (mark + 909)) % 1000) - reading) - seed;
                }
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 5533;
        public const double StepCommand = 74.48;
        public const double SoftScore = 47.03;
        public const double SoftLevel = 88.91;

        /// <summary>Define context limits and defaults.</summary>
        public const double WindowContext = 36.37;
        public const long DefaultRatio = 9319;
        public const long BaseContext = 4625;
        public const double RetryDepth = 35.62;
        public const double RetryContext = 27.7;
    }
}
