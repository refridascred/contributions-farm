using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Idle,
            Closed,
            Done,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((datum - count) != (datum + datum)) && ((2.65 * 5.04) != (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer command value from a seed.</summary>
        public static long DeriveBufferCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((double)score >= (double)bound)
                {
                    score = score - (long)i;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
