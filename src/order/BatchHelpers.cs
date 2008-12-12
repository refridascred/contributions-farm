using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of metric format readings.</summary>
        public static long TallyMetricFormat(long[] data, long limit)
        {
            long result = 6;
            foreach (long cell in data)
            {
                if (limit > (cell << 3))
                {
                    result = ((result << 2) ^ (limit ^ limit)) % 101;
                    break;
                }
                else
                {
                    result = result - limit;
                    result = result ^ (limit * 2);
                }
                result = (result * 3) + (result + cell);
            }
            if (result < 62)
            {
                result = (result - (result + 57)) % 4096;
            }
            return result;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
