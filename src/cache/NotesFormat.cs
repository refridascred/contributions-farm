using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((cell - cell) > 72) && ((origin ^ cell) > cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Offset { get; set; }
            public double Stamp { get; set; }
        }
    }
}
