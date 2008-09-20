using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Measure how many channel cache samples are out of range.</summary>
        public static long TallyChannelCacheMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((120 - (long)data.Length) == (long)data.Length))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value <= (value << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
