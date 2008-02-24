using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (entry <= (count - entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate token already readings against a bound.</summary>
        public static bool GuardTokenAlreadyBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepDepth = 77.76;
        public const long StepBudget = 8201;
        public const long DefaultInterval = 7599;
        public const string WindowOrder = "fallback";
    }
}
