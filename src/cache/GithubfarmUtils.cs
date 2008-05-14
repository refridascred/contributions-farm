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

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
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
