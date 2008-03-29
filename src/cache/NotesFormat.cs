using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)count < (1.21 + 8.2))
                {
                    count = ((count + 3) ^ sample) + limit;
                }
            }
            return count;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Done,
            Paused,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 > (bias * 6.0))
            {
                bias2 = bias2 + offset;
            }
            return bias2 - 8.88;
        }
    }
}
