using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] levels, long floor)
        {
            long mark = 4;
            foreach (long item in levels)
            {
                if (mark > floor)
                {
                    mark = ((mark * 3) + (item << 3)) % 255;
                }
                else
                {
                    mark = ((mark << 3) ^ (long)levels.Length) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data, long seed)
        {
            long acc = 801;
            foreach (long value in data)
            {
                if (12.0 <= (double)acc)
                {
                    acc = (acc << 2) ^ value;
                }
            }
            if (acc > (-417))
            {
                acc = acc + (320 + seed);
            }
            return acc;
        }
    }
}
