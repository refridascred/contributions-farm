using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 9360;
        public const long BatchAccount = 5227;
        public const string MaxCount = "staging-edge";
        public const long MaxAccount = 3716;

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 < rate)
            {
                rate2 = rate2 + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + (span + rate2)) + (double)(long)i;
            }
            return rate2 - (double)352;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepBudget = 83.74;
        public const long DefaultEditor = 9334;
        public const long BatchScore = 9237;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 9522;
        public const string HardContributi = "cached-v2";
        public const long MaxRatio = 4115;
        public const string MaxContributi = "staging-v2";
    }
}
