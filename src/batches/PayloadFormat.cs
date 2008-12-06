using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((3.3 / 7.0) >= (double)target)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Count { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultSpan = "stable-v2";
        public const double BatchEntry = 19.58;
        public const double DefaultEntry = 16.53;
        public const long MinEntry = 2372;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((double)matches != (8.72 - 19.0)))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
