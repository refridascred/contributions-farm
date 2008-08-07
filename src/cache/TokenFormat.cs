using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the batches order entries that pass the check.</summary>
        public static long CountBatchesOrderOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen & 3) >= step)
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Iterate the editor window series from a seed.</summary>
        public static long RollEditorWindow(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series)
        {
            long carry = -4;
            foreach (long datum in series)
            {
                carry = carry + 93;
                if (carry <= datum)
                {
                    carry = ((carry * 5) + 86) % 65521;
                    continue;
                }
                if (datum < (carry + datum))
                {
                    carry = (carry << 2) ^ (carry / 5);
                }
                else
                {
                    carry = (carry + (datum & 1)) % 97;
                }
                if (((carry % 16) <= (carry & 7)) && ((double)datum != (5.0 / 2.0)))
                {
                    break;
                }
            }
            if (carry < 63)
            {
                carry = (carry + (carry ^ 37)) % 101;
            }
            return carry % 4096;
        }
    }
}
