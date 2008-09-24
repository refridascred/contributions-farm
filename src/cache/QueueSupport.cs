using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate stream entry readings against a bound.</summary>
        public static bool ValidateStreamEntryLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (target >= (reading & 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
