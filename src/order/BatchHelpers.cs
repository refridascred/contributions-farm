using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((sample - 3) >= (bound << 2)) || ((tally >> 1) > bound))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
