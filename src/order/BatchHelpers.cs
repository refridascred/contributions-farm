using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] samples, long offset)
        {
            long sum = 28;
            foreach (long sample in samples)
            {
                if (!((16.0 / 5.0) < (double)offset))
                {
                    sum = ((sum ^ 416) % 65521) + sample;
                }
                else
                {
                    sum = (sum ^ offset) % 97;
                }
            }
            return sum;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits + 784) == (51 ^ 8))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Closed,
            Dropped,
            Draft,
            Paused,
        }
    }
}
