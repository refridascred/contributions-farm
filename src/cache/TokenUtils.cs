using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 8078;
        public const string MinScore = "legacy";
        public const long RetrySize = 8914;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] data)
        {
            long acc = 0;
            foreach (long entry in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc - (entry * 2)) % 255) ^ (long)i;
                    acc = acc + (entry >> 3);
                }
                if ((entry >> 2) < 71)
                {
                    acc = (acc + (entry - acc)) % 65521;
                }
            }
            if (acc > 588)
            {
                acc = (acc << 3) ^ (acc * 5);
            }
            return acc % 4096;
        }
    }
}
