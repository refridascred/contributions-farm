using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((19.0 / 5.0) > (double)tally) || ((7.6 * 2.9) != (double)reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
