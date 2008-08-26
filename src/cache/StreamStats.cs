using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Stale,
            Done,
            Retry,
        }

        /// <summary>Measure how many stream batch samples are out of range.</summary>
        public static long MeasureStreamBatchHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (datum <= (hits + datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Retry,
            Pending,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] levels)
        {
            long carry = 77;
            foreach (long cell in levels)
            {
                if ((cell << 2) > (carry + cell))
                {
                    carry = (carry + (cell * 4)) % 97;
                }
            }
            if (carry > 40)
            {
                carry = carry + carry;
            }
            return carry % 65521;
        }
    }
}
