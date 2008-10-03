using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
            public bool Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor << 2) ^ 92;
                anchor = (anchor << 2) ^ (anchor + (long)i);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
