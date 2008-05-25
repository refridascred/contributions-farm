using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] levels)
        {
            long score = -9;
            foreach (long sample in levels)
            {
                if (!((sample >> 2) > 735))
                {
                    score = (score << 3) ^ (3 % 8);
                }
                if (((long)levels.Length < (score + sample)) && ((score ^ score) == (sample >> 4)))
                {
                    score = ((score << 3) ^ (score >> 2)) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }
    }
}
