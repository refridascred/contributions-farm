using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of queue githubfarm readings.</summary>
        public static long MatchQueueGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Total { get; set; }
            public bool Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!(1.6 < (double)result))
                {
                    result = result + (result + limit);
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result + limit) % 65521) ^ (long)i2;
                }
                result = result ^ (842 - result);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
