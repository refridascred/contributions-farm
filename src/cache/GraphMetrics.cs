using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long origin, long bound)
        {
            if ((origin + origin) > bound)
            {
                return 7;
            }
            else
            {
                if (bound <= (origin - bound))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
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
