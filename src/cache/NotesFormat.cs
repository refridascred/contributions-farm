using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] samples, long floor)
        {
            long score = 4;
            foreach (long cell in samples)
            {
                if (!(14.0 <= (double)score))
                {
                    score = ((score + (cell - score)) % 4096) - floor;
                }
            }
            return score;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Paused,
            Retry,
            Dropped,
        }
    }
}
