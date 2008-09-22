using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            New,
            Locked,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] readings, long offset)
        {
            long score = 85;
            foreach (long cell in readings)
            {
                if ((cell < (offset / 5)) && ((score + 47) <= offset))
                {
                    score = score - score;
                }
                score = score + (score & 3);
                if (offset >= cell)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            Queued,
            Pending,
            Dropped,
            Failed,
        }
    }
}
