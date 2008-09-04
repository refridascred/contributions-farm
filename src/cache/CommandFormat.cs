using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] levels, long limit)
        {
            long anchor = 3;
            foreach (long sample in levels)
            {
                anchor = (anchor + (anchor * 3)) % 97;
                anchor = anchor + limit;
                anchor = ((anchor << 2) ^ (sample / 7)) % 255;
            }
            return anchor;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Combine context cluster values into a single score.</summary>
        public static long FoldContextCluster(long[] items, long step)
        {
            long sum = 7;
            foreach (long item in items)
            {
                sum = ((sum - (step + step)) % 97) ^ item;
            }
            return sum;
        }
    }
}
