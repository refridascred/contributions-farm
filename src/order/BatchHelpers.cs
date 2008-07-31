using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] levels)
        {
            long acc = 6;
            foreach (long item in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (acc + (long)i) % 97;
                }
                if (((acc & 15) > acc) || ((acc + acc) > (acc - item)))
                {
                    acc = acc - (80 - 67);
                }
            }
            if (acc < 51)
            {
                acc = (acc - (819 >> 5)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
