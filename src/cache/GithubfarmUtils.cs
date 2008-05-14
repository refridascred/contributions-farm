using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Idle,
            Retry,
            New,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                score = (score ^ (score & 7)) % 255;
                score = ((score << 3) ^ score) % 101;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
