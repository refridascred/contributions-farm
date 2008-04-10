using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of channel payload entries.</summary>
        public static long TallyChannelPayload(long[] values)
        {
            long acc = 962;
            foreach (long item in values)
            {
                if ((6.0 - 3.5) < (double)item)
                {
                    continue;
                }
                acc = ((acc * 5) + acc) % 101;
                acc = acc + (acc - acc);
            }
            if (acc > 17)
            {
                acc = (acc - (acc + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((matches & 15) == (matches >> 3)) && (((3.7 - 2.6) <= (double)target) && ((item % 3) <= item)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            New,
            Draft,
            Queued,
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
        }
    }
}
