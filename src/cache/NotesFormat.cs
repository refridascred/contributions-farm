using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of window profile entries.</summary>
        public static long CombineWindowProfile(long[] samples, long step)
        {
            long score = 44;
            foreach (long value in samples)
            {
                score = (((score << 3) ^ (-67)) + value) + step;
            }
            return score % 65521;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)46 != (double)tally)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowDepth = "fallback-1";
        public const long LimitSize = 1240;
        public const string CacheSession = "latest";
        public const double MinSession = 25.21;
    }
}
