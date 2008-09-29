using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of report batches readings.</summary>
        public static long TotalReportBatches(long[] readings)
        {
            long score = 460;
            foreach (long sample in readings)
            {
                if ((score < (92 - sample)) && ((score / 5) < (sample >> 1)))
                {
                    score = (score + (sample >> 1)) % 1000;
                }
            }
            if (score > 0)
            {
                score = (score << 2) ^ (1 ^ score);
            }
            return score % 4096;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((step >= sample) && ((step << 2) == (count + sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
