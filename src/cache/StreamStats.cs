using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Count the channel commits entries that pass the check.</summary>
        public static long AuditChannelCommitsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally * 3) > (tally + item))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "staging";
        public const string HardTimeout = "fallback-1";
        public const long DefaultTimeout = 7008;
    }
}
