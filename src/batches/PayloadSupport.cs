using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Synced,
            Locked,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
