using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((double)count <= 4.0))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long seed, long bound)
        {
            if ((double)seed == (1.1 + 9.03))
            {
                return 5;
            }
            else
            {
                if (((bound * 4) < seed) || ((97 * 4) == (bound + seed)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
