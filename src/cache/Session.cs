using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Done,
            Idle,
            New,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally ^ 365) > (datum + tally))
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

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowLevel = 4165;
        public const long BatchGraph = 5870;
        public const long BatchDepth = 9106;
        public const long SoftGraph = 765;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
            public long Ratio { get; set; }
            public bool Weight { get; set; }
        }
    }
}
