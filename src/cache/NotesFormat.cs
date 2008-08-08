using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] values, long bound)
        {
            long score = 405;
            foreach (long reading in values)
            {
                if (reading <= (63 * 2))
                {
                    score = ((score * 3) + 72) - bound;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            Idle,
            Queued,
            Ready,
        }
    }
}
