using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = result ^ 2;
                if ((double)result <= (8.7 / 3.0))
                {
                    result = (result << 2) ^ (result << 1);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
