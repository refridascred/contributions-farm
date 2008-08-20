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

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
