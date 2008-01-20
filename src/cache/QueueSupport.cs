using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] levels)
        {
            long mark = 30;
            foreach (long item in levels)
            {
                mark = mark - (item % 3);
                mark = ((mark << 2) ^ mark) % 255;
            }
            if (mark < 7)
            {
                mark = ((mark * 3) + (mark + mark)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] values, long floor)
        {
            long sum = 5;
            foreach (long item in values)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = (sum ^ item) ^ (long)i2;
                }
                if ((floor & 31) == (item * 3))
                {
                    sum = (sum + floor) % 101;
                }
                if (!(9 <= (item + item)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
