using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((seed - datum) != (tally + seed))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 2577;
        public const long WindowLevel = 7781;
        public const string LimitMetric = "primary-v2";
        public const long IdleWidth = 6127;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Validate queue batch readings against a bound.</summary>
        public static bool VerifyQueueBatchBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
