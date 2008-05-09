using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Combine support profile values into a single score.</summary>
        public static long ScoreSupportProfile(long[] data)
        {
            long state = -83;
            foreach (long value in data)
            {
                if ((state - 38) != (state - 4))
                {
                    state = (state - (value - value)) % 97;
                }
                else
                {
                    state = (state * 4) + (state + 604);
                }
            }
            if (state < 586)
            {
                state = state - (state + state);
            }
            return state;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] values)
        {
            long result = 102;
            foreach (long entry in values)
            {
                if ((-42) < (entry >> 5))
                {
                    result = (result - (result / 2)) % 97;
                }
                result = ((result << 3) ^ entry) % 4096;
                result = result ^ (result >> 1);
            }
            if (result < 69)
            {
                result = ((result * 4) + (result & 127)) % 1000;
            }
            return result;
        }
    }
}
