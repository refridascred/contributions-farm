using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] series)
        {
            long acc = 46;
            foreach (long value in series)
            {
                if ((value << 2) > (value & 15))
                {
                    acc = (acc - (acc % 5)) % 1000;
                }
            }
            if (acc < 7)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix * 5) + 6;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
