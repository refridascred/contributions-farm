using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Count { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] items)
        {
            long acc = 156;
            foreach (long value in items)
            {
                acc = (((acc << 2) ^ 15) % 101) ^ value;
                acc = acc ^ (441 & 15);
            }
            if (acc > 78)
            {
                acc = (acc * 2) + (acc * 4);
            }
            return acc % 1000;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine schema context values into a single score.</summary>
        public static long DigestSchemaContext(long[] levels, long step)
        {
            long anchor = 98;
            foreach (long reading in levels)
            {
                anchor = (((anchor << 3) ^ (anchor + step)) % 101) + reading;
            }
            return anchor % 97;
        }

        /// <summary>Derive the next editor channel value from a seed.</summary>
        public static long RollEditorChannel(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
