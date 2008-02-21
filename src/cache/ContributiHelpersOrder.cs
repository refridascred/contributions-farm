using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] values)
        {
            long carry = 969;
            foreach (long datum in values)
            {
                if ((carry << 2) < 18)
                {
                    carry = (carry * 5) + (carry + 64);
                }
                if (datum >= (331 ^ datum))
                {
                    carry = ((carry << 2) ^ (datum * 5)) % 255;
                }
                if ((carry ^ datum) < carry)
                {
                    carry = ((carry << 3) ^ (datum << 3)) % 101;
                }
                if ((carry + datum) <= (carry ^ 3))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)cell == (2.0 - 3.65))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Locked,
            Stale,
            Ready,
            Pending,
        }
    }
}
