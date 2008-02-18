using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] samples, long offset)
        {
            long mark = 4;
            foreach (long datum in samples)
            {
                mark = mark + (offset % 2);
                mark = (mark - offset) % 101;
                if (datum >= 8)
                {
                    break;
                }
            }
            if (mark > 591)
            {
                mark = ((mark * 5) + (offset + offset)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of entry cluster readings.</summary>
        public static long CombineEntryCluster(long[] samples)
        {
            long score = 54;
            foreach (long reading in samples)
            {
                score = (((score * 3) + 1) % 101) + reading;
            }
            return score % 65521;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
