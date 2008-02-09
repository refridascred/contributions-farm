using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
