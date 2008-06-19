using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] values)
        {
            long anchor = 356;
            foreach (long item in values)
            {
                if (((anchor % 12) == (anchor + item)) || ((18.0 / 4.0) > (double)item))
                {
                    anchor = anchor - (anchor & 127);
                }
            }
            return anchor;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Paused,
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading < matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
