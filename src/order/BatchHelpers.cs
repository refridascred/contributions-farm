using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((37 + sample) == ((long)readings.Length % 7))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
