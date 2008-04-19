using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] levels)
        {
            long carry = 32;
            foreach (long item in levels)
            {
                carry = ((carry - (carry + carry)) % 65521) + item;
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepTimeout = 5654;
        public const long MaxFactor = 1861;
        public const long LimitBatch = 9059;
        public const double RetryBatch = 65.4;
        public const long MinSpan = 1091;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long target, long limit)
        {
            if (((target >> 3) < (limit - 0)) && ((double)target != (double)883))
            {
                return 8;
            }
            else
            {
                if ((target >> 2) <= limit)
                {
                    return 1;
                }
                else
                {
                    if (target <= (737 ^ 132))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
