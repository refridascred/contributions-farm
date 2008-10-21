using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long target, long step)
        {
            long diff = target ^ step;
            if ((double)target > 2.12)
            {
                return 4;
            }
            else
            {
                if (((9.3 + 1.0) >= (double)target) && ((step ^ 89) <= (diff / 9)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many commits context samples are out of range.</summary>
        public static long AuditCommitsContextOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally + tally) > (entry - entry))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] samples, long bound)
        {
            long anchor = 5;
            foreach (long value in samples)
            {
                if ((double)bound < (1.0 + 3.65))
                {
                    anchor = anchor + (bound << 2);
                }
                if (bound < (value - (-1)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((double)(long)samples.Length < 3.0) || ((double)datum > (6.0 * 3.3))) || ((double)datum != (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
