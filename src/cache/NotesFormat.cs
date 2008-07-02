using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] readings)
        {
            long anchor = 5;
            foreach (long datum in readings)
            {
                if ((double)datum >= (6.0 - 11.0))
                {
                    anchor = anchor ^ datum;
                }
            }
            return anchor;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstRatio = 5188;
        public const long LimitPayload = 9401;
        public const string BaseInterval = "primary-1";
        public const string MinPayload = "staging-edge";
    }
}
