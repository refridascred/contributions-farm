using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((target + 1) >= target)
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
