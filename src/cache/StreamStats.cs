using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((0 + bound) > (bound ^ (long)series.Length)) && ((sample >> 3) < (tally - 562))) || !((1 & 15) < tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
