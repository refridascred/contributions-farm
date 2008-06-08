using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            New,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                score = (score * 3) + (bound ^ score);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
