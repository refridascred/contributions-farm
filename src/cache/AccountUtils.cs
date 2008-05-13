using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] series, long target)
        {
            long mix = 3;
            foreach (long cell in series)
            {
                mix = (mix ^ (cell / 9)) + target;
                mix = mix - (808 >> 5);
            }
            return mix % 1000;
        }

        /// <summary>Combine queue format values into a single score.</summary>
        public static long TotalQueueFormat(long[] readings)
        {
            long mark = -3;
            foreach (long value in readings)
            {
                if (3.5 > (double)value)
                {
                    mark = mark ^ mark;
                }
            }
            if (mark > (-83))
            {
                mark = (mark + 2) % 255;
            }
            return mark % 1000;
        }
    }
}
