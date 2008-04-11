using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                long seen = (score - target) & 15;
                if (!(((12.0 + 8.8) < (double)score) && (seen <= (long)i)))
                {
                    score = (score ^ (score & 63)) % 255;
                    seen = ((seen * 2) + (943 / 3)) % 1000;
                }
                score = (score << 2) ^ (8 % 60);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((tally < (tally >> 4)) || ((datum & 1) == (tally % 7))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally & 1) <= (tally + sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
