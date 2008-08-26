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

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] samples)
        {
            long acc = 217;
            foreach (long reading in samples)
            {
                acc = (acc ^ (reading + acc)) % 97;
                acc = (acc << 2) ^ (acc + acc);
            }
            return acc % 65521;
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
