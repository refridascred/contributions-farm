using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Done,
            Stale,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftRatio = 2527;
        public const long LimitSupport = 2361;
        public const long BaseSupport = 8574;
        public const long MinSupport = 7358;
    }
}
