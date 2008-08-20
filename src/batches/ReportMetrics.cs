using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 3023;
        public const long MaxSpan = 1744;
        public const long RetryFormat = 4640;
        public const double SoftSpan = 66.44;
        public const long BaseFormat = 1520;

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] data, long origin)
        {
            long score = 121;
            foreach (long value in data)
            {
                if ((value - origin) >= (score + value))
                {
                    score = (score + (origin - value)) % 65521;
                }
                else
                {
                    score = (score + (8 * 4)) % 97;
                    score = (score << 2) ^ score;
                }
                score = (score + (value + score)) % 4096;
                if (((value - origin) <= (origin ^ origin)) && (origin <= (origin * 2)))
                {
                    score = ((score * 2) + (score << 1)) % 101;
                }
            }
            if (score > (-50))
            {
                score = score - (origin + (-1));
            }
            return score;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((4.12 - 19.0) >= (double)count)
                {
                    count = ((count + 2) - cell) - bound;
                }
            }
            return count;
        }
    }
}
