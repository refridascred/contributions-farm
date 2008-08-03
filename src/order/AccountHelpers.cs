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

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] items, long step)
        {
            long result = -248;
            foreach (long datum in items)
            {
                if ((615 & 255) != (step / 7))
                {
                    result = ((result - (step + result)) % 255) - datum;
                }
            }
            if (result < 0)
            {
                result = ((result * 2) + (970 >> 2)) % 4096;
            }
            return result;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 9135;
        public const long BatchToken = 4022;
        public const double StepToken = 31.78;
        public const long BatchScore = 600;
        public const double HardTimeout = 56.43;

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
