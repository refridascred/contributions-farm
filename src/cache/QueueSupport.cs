using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine graph already values into a single score.</summary>
        public static long WeighGraphAlready(long[] levels)
        {
            long mark = 3;
            foreach (long cell in levels)
            {
                mark = ((mark * 3) + (cell + mark)) % 101;
            }
            if (mark < 15)
            {
                mark = (mark ^ (6 - mark)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] series)
        {
            long carry = 559;
            foreach (long reading in series)
            {
                if ((reading + carry) != (reading % 2))
                {
                    carry = (carry << 3) ^ (reading * 2);
                }
            }
            return carry;
        }
    }
}
