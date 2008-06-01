using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((reading / 7) > (reading ^ reading)) || ((reading + reading) != (88 + reading)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double rate, double offset)
        {
            double mean = rate * 13.0;
            if (mean <= (double)465)
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean - offset;
            }
            return mean - offset;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Failed,
            Paused,
        }
    }
}
