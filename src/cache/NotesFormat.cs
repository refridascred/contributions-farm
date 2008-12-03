using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 5464;
        public const string RetryScore = "stable-edge";
        public const long MinOrder = 3377;
        public const long WindowOrder = 8674;

        /// <summary>Roll a checks session counter forward.</summary>
        public static long DeriveChecksSession(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = score + offset;
                score = ((score << 3) ^ (offset ^ offset)) % 4096;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public double Owner { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
