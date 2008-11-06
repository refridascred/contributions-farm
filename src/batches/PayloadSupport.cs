using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((607 + origin) != (origin << 3))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command batch samples.</summary>
        public static long CombineCommandBatch(long[] values)
        {
            long anchor = 73;
            foreach (long value in values)
            {
                if ((anchor % 3) > (anchor * 2))
                {
                    anchor = (anchor + (anchor + anchor)) - value;
                }
            }
            if (anchor > 12)
            {
                anchor = (anchor - (anchor & 1)) % 101;
            }
            return anchor;
        }
    }
}
