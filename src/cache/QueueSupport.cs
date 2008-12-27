using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Region { get; set; }
            public double Score { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
