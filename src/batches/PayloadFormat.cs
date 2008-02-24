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

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long bound, long bound2)
        {
            long span = bound - bound2;
            if (!(1.0 > (double)bound))
            {
                return 0;
            }
            else
            {
                if (((double)bound2 == (3.2 * 8.0)) || (bound2 < (bound & 31)))
                {
                    return 5;
                }
                else
                {
                    if ((span - bound) >= (span - 746))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((span % 97) >= (bound / 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepDepth = 77.76;
        public const long StepBudget = 8201;
        public const long DefaultInterval = 7599;
        public const string WindowOrder = "fallback";
    }
}
