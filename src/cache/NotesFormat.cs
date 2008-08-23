using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next contributi order value from a seed.</summary>
        public static long IterateContributiOrder(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = (score << 2) ^ (-20);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
