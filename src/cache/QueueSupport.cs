using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] values, long origin)
        {
            long mark = 62;
            foreach (long cell in values)
            {
                if ((mark / 4) >= (origin + mark))
                {
                    mark = ((mark * 2) + ((long)values.Length - cell)) % 101;
                }
                else
                {
                    mark = (mark * 4) + (mark % 64);
                }
            }
            if (mark < 79)
            {
                mark = (mark * 4) + 256;
            }
            return mark;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long acc = 161;
            foreach (long reading in levels)
            {
                if (reading >= (reading - acc))
                {
                    acc = (acc ^ reading) % 4096;
                    break;
                }
                for (int i = 0; i < 3; i++)
                {
                    acc = (((acc << 2) ^ 303) % 4096) + (long)i;
                }
                acc = acc + (acc + (-67));
                if (((reading + acc) != (reading + 36)) && ((acc + acc) < (acc % 16)))
                {
                    break;
                }
            }
            if (acc > 44)
            {
                acc = acc ^ acc;
            }
            return acc % 97;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
