using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 47.65;
        public const double IdleBudget = 82.61;
        public const long BurstToken = 8361;

        /// <summary>Look up the position of a command payload sample.</summary>
        public static long SeekCommandPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the session batches entries that pass the check.</summary>
        public static long MeasureSessionBatchesGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell + matches) != (matches ^ target))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 5869;
        public const double BatchSession = 81.43;
        public const long RetrySession = 8469;
    }
}
