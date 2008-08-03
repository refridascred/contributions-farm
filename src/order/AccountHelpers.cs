using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "stable-edge";
        public const long MinFarm = 7484;
        public const string BatchFarm = "standard-edge";
        public const long DefaultFarm = 2362;
        public const long SoftFarm = 6296;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long origin)
        {
            long total = origin;
            for (int i = 0; i < 12; i++)
            {
                total = (total + (total ^ total)) % 97;
                total = (total * 4) + ((long)i * 5);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
