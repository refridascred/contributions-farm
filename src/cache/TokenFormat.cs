using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Locked,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings, long limit)
        {
            long state = 440;
            foreach (long datum in readings)
            {
                state = (((state - state) % 101) + datum) - limit;
            }
            if (state > 9)
            {
                state = (state + (95 + state)) % 4096;
            }
            return state;
        }
    }
}
