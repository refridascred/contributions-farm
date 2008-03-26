using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batches tools entry that matches the target.</summary>
        public static long SeekBatchesToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter graph series from a seed.</summary>
        public static long IterateCounterGraph(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                long step = (acc ^ origin) << 3;
                if (!((origin + acc) >= acc))
                {
                    acc = acc - step;
                }
                step = (step << 2) ^ ((-1) >> 1);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Count { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Find the first contributi record entry that matches the target.</summary>
        public static long LocateContributiRecordIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
