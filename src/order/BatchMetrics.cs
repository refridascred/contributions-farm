using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((9.62 + 12.0) == (double)offset) || ((datum - datum) > (seen ^ datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] readings)
        {
            long result = 3;
            foreach (long reading in readings)
            {
                if (((-4) ^ reading) < (40 - 88))
                {
                    result = (result << 2) ^ (190 * 2);
                }
                else
                {
                    result = ((result << 3) ^ result) % 97;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Dropped,
            Closed,
            Pending,
            Stale,
            Failed,
        }
    }
}
