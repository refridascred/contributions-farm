using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            New,
            Closed,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] readings)
        {
            long result = 104;
            foreach (long value in readings)
            {
                if (result > value)
                {
                    result = (result + result) % 255;
                }
            }
            return result % 65521;
        }
    }
}
