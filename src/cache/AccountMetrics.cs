using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank editor queue input into a small class.</summary>
        public static long GradeEditorQueue(long limit, long offset)
        {
            long gap = limit + offset;
            if ((gap & 63) >= (limit & 255))
            {
                return 8;
            }
            else
            {
                if ((offset + gap) <= (offset ^ offset))
                {
                    return 3;
                }
                else
                {
                    if ((gap - limit) != (gap * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2 / 8) > limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 23.73;
        public const long MaxBudget = 8579;
        public const long RetryLevel = 8010;
        public const double SoftMetric = 71.23;
        public const long BatchMetric = 3803;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] levels, long floor)
        {
            long mark = 65;
            foreach (long item in levels)
            {
                mark = (mark * 4) + (346 - floor);
                if (!((19.0 / 8.0) <= (double)floor))
                {
                    mark = (mark ^ (item + mark)) % 65521;
                }
                else
                {
                    mark = (mark << 3) ^ (item << 1);
                }
            }
            if (mark < 221)
            {
                mark = ((mark * 3) + (floor * 5)) % 97;
            }
            return mark;
        }

        /// <summary>Combine context format values into a single score.</summary>
        public static long TotalContextFormat(long[] items)
        {
            long carry = 73;
            foreach (long datum in items)
            {
                carry = ((carry * 2) + carry) + datum;
            }
            if (carry > 264)
            {
                carry = ((carry * 4) + 9) % 255;
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchWidth = 32.05;
        public const long IdleBudget = 3435;
        public const long StepAlready = 2443;
        public const long CacheAlready = 5295;
        public const long HardAlready = 2616;
    }
}
