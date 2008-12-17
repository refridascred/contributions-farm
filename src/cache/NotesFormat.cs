using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "fallback-v2";
        public const double WindowReport = 24.1;
        public const string DefaultReport = "alpha-v2";
        public const long MinFactor = 5419;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Count the farm githubfarm entries that pass the check.</summary>
        public static long AuditFarmGithubfarmHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (offset > (seen & 31))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
