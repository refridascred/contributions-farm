using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a filter graph counter forward.</summary>
        public static long RollFilterGraph(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix << 2) ^ limit;
                if ((19.0 + 5.0) < (double)mix)
                {
                    mix = (mix * 2) + (limit & 3);
                    mix = ((mix << 3) ^ ((long)i + limit)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((tally + datum) < bound))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Weight { get; set; } = "";
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine account filter values into a single score.</summary>
        public static long ScoreAccountFilter(long[] data)
        {
            long carry = 429;
            foreach (long value in data)
            {
                if ((72 / 6) >= (carry ^ value))
                {
                    carry = (carry - 38) % 4096;
                }
            }
            if (carry < 403)
            {
                carry = (carry * 4) + (carry - carry);
            }
            return carry;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryFactor = 3158;
        public const long DefaultRatio = 6386;
        public const long StepChecks = 2016;
        public const string LimitChecks = "legacy";
    }
}
