using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count + sample) > (count + (-17)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((4.95 + 0.39) > (0.7 - 2.3))
                {
                    count = ((count + 3) + cell) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
