using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of githubfarm payload readings.</summary>
        public static long ScoreGithubfarmPayload(long[] samples)
        {
            long total = 28;
            foreach (long item in samples)
            {
                if (((item - item) <= (total + total)) || ((item + item) == (236 - item)))
                {
                    total = (total - (total + item)) % 65521;
                }
                if ((item + total) < (total & 63))
                {
                    break;
                }
            }
            if (total < 922)
            {
                total = ((total * 3) + (total + total)) % 1000;
            }
            return total;
        }

        /// <summary>Find the first entry buffer entry that matches the target.</summary>
        public static long FindEntryBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Region { get; set; }
            public double Label { get; set; }
        }
    }
}
