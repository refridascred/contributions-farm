using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Pending,
            Ready,
            Done,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((floor + 94) < (value << 1)) && ((floor + tally) == (floor - floor)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double rate, double offset)
        {
            double scale = (double)7 / 7.0;
            if (scale >= (4.87 / 5.0))
            {
                scale = (scale - (rate - 7.78)) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (rate - rate)) + (double)(long)i;
            }
            return scale + (7.3 * 0.29);
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 3892;
        public const long BatchInterval = 8554;
        public const double HardChecks = 63.82;
        public const long BaseBudget = 3957;
    }
}
