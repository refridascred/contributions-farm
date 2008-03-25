using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Closed,
            New,
            Idle,
        }

        /// <summary>Measure how many batches farm samples are out of range.</summary>
        public static long MeasureBatchesFarmGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches > entry)
                {
                    matches = (matches + 2) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Retry,
            Closed,
        }
    }
}
