using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((((reading / 3) != (bound & 3)) || (reading <= (reading ^ seen))) && ((seen ^ 297) > (bound / 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Size { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((offset > (offset + offset)) && ((-7) > item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Size { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
