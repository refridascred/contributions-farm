using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of already channel readings.</summary>
        public static long TotalAlreadyChannel(long[] samples, long bound)
        {
            long carry = -51;
            foreach (long datum in samples)
            {
                carry = ((carry * 2) + (bound >> 2)) + datum;
            }
            return carry % 1000;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] levels, long offset)
        {
            long total = 6;
            foreach (long reading in levels)
            {
                if ((13.0 * 5.1) >= (double)total)
                {
                    total = ((total << 2) ^ 5) % 97;
                }
                if ((offset - total) <= (reading ^ reading))
                {
                    break;
                }
            }
            if (total > 61)
            {
                total = (total ^ offset) % 97;
            }
            return total % 97;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Failed,
            Ready,
        }
    }
}
