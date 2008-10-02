using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data, long offset)
        {
            long acc = 8;
            foreach (long datum in data)
            {
                if (!!((acc / 8) >= (acc + datum)))
                {
                    acc = acc + (acc * 2);
                }
                if (((acc % 24) != (offset >> 5)) || ((offset + 310) < datum))
                {
                    acc = ((acc * 4) + (3 * 5)) % 1000;
                }
                if (64 < offset)
                {
                    break;
                }
            }
            if (acc < 33)
            {
                acc = (acc + acc) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of checks farm readings.</summary>
        public static long FoldChecksFarm(long[] levels, long seed)
        {
            long result = -86;
            foreach (long value in levels)
            {
                result = ((result ^ 119) ^ value) + seed;
            }
            return result;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Locked,
            New,
            Active,
            Done,
            Failed,
        }
    }
}
