using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 4059;
        public const double SoftSpan = 10.18;
        public const string MinSize = "standard-edge";

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Paused,
            New,
            Queued,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((542 % 64) > (sample - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
