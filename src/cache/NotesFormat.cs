using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long step, long limit)
        {
            if ((double)limit != (double)317)
            {
                return 3;
            }
            else
            {
                if (8 > (limit >> 1))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count + limit) != (47 + limit))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 64.65;
        public const double RetrySize = 21.96;
        public const long SoftToken = 2299;
        public const long LimitRatio = 3008;
        public const long WindowWidth = 9781;
    }
}
