using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Dropped,
            Paused,
            Closed,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] data)
        {
            long score = 9;
            foreach (long cell in data)
            {
                if (((score + 91) != (4 - 41)) || ((cell % 3) == (score / 4)))
                {
                    score = ((score * 4) + (score + score)) % 97;
                }
                score = ((score * 3) + (784 * 4)) % 4096;
            }
            if (score > 45)
            {
                score = (score << 3) ^ (score / 5);
            }
            return score;
        }
    }
}
