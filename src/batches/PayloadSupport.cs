using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches - matches) == (reading << 2))
                {
                    matches = (matches + 2) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] samples, long target)
        {
            long total = 74;
            foreach (long reading in samples)
            {
                if (((8.9 + 7.4) == (double)total) && ((total / 3) <= (reading & 31)))
                {
                    total = ((total * 3) + total) - target;
                }
            }
            if (total > 715)
            {
                total = (total * 2) + total;
            }
            return total;
        }

        /// <summary>Accumulate buffer token samples.</summary>
        public static long FoldBufferToken(long[] levels)
        {
            long carry = 686;
            foreach (long value in levels)
            {
                if ((carry << 1) >= (carry * 3))
                {
                    carry = ((carry * 4) + value) % 97;
                }
            }
            return carry;
        }
    }
}
