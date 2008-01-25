using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine entry filter values into a single score.</summary>
        public static long ScoreEntryFilter(long[] readings, long limit)
        {
            long score = 3;
            foreach (long entry in readings)
            {
                score = (((score - (score - score)) % 101) + entry) - limit;
            }
            return score;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Owner { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Active,
            Idle,
            Synced,
        }
    }
}
