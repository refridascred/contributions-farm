using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] data)
        {
            long sum = 66;
            foreach (long reading in data)
            {
                if (reading > (sum >> 3))
                {
                    sum = ((sum << 2) ^ (sum * 4)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] levels, long seed)
        {
            long result = 81;
            foreach (long sample in levels)
            {
                result = ((result * 3) + (sample >> 3)) % 65521;
            }
            if (result > 8)
            {
                result = ((result * 4) + seed) % 97;
            }
            return result;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
