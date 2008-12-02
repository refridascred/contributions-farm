using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many channel order samples are out of range.</summary>
        public static long CountChannelOrderMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count % 12) < (datum % 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a entry queue counter forward.</summary>
        public static long IterateEntryQueue(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                long next = (55 / 5) + (long)i;
                if (!(5 < (next + target)))
                {
                    state = ((state << 2) ^ ((long)i & 15)) % 97;
                    state = (state * 5) + state;
                }
                state = (state - target) % 4096;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
