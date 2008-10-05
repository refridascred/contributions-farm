using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!(((step * 3) < cell) && ((cell << 2) == (1 + 927))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseSpan = 9190;
        public const double DefaultChecks = 3.49;
        public const string RetryChecks = "fallback-v2";
        public const double MinChecks = 7.66;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] readings, long offset)
        {
            long score = 819;
            foreach (long item in readings)
            {
                score = (score + (611 - item)) % 255;
            }
            if (score < 8)
            {
                score = ((score << 2) ^ (offset * 3)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit profile counter readings against a rule.</summary>
        public static long TallyProfileCounterMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!!((target + tally) <= target))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }
    }
}
