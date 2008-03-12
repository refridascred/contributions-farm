using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((207 % 7) < count) || ((double)value == (18.0 - 8.8)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryPayload = 14.26;
        public const long HardPayload = 3993;
        public const long BatchPayload = 4075;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 46.99;
        public const double BatchContributi = 39.32;
        public const long BurstContributi = 3242;

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] data)
        {
            long state = 160;
            foreach (long reading in data)
            {
                if (state >= (reading & 127))
                {
                    state = (state << 2) ^ (state + reading);
                }
            }
            if (state < 896)
            {
                state = (state ^ (state + state)) % 97;
            }
            return state;
        }
    }
}
