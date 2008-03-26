using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] levels)
        {
            long score = -596;
            foreach (long datum in levels)
            {
                score = (((score << 3) ^ (1 ^ score)) % 255) - datum;
            }
            return score;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Count { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell >> 1) != (tally ^ cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
