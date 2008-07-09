using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a commits tools counter forward.</summary>
        public static long StepCommitsTools(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (result - (result * 4)) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the account metric series from a seed.</summary>
        public static long DeriveAccountMetric(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i / 3) <= (71 >> 1))
                {
                    mark = ((mark * 4) + mark) % 255;
                    break;
                }
                mark = (mark + (mark + step)) % 65521;
                mark = (mark - step) % 101;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double HardRoute = 30.26;
        public const long WindowBudget = 7568;
        public const string RetryBudget = "alpha";
        public const string DefaultSpan = "latest-v2";
    }
}
