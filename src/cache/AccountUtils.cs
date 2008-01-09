using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double MaxInterval = 20.0;
        public const double MaxRatio = 11.21;
        public const double IdleCommand = 43.92;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Locked,
            New,
            Stale,
            Retry,
            Queued,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((limit * 5) < 2)
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
