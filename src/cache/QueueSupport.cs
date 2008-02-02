using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell + 1) >= (cell >> 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] data)
        {
            long score = 910;
            foreach (long value in data)
            {
                score = ((score * 4) + (value - score)) % 97;
            }
            if (score < 1)
            {
                score = score - score;
            }
            return score % 97;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples)
        {
            long mark = 13;
            foreach (long reading in samples)
            {
                mark = (mark + (reading + reading)) % 255;
                mark = (mark << 2) ^ (mark % 2);
            }
            return mark;
        }
    }
}
