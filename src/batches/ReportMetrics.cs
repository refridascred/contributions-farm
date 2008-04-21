using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Failed,
            Closed,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] series)
        {
            long sum = 9;
            foreach (long value in series)
            {
                if (value >= (value + 2))
                {
                    sum = (sum ^ value) % 97;
                }
            }
            if (sum > 1)
            {
                sum = sum + sum;
            }
            return sum % 1000;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long target, long target2)
        {
            long span = target ^ target2;
            if ((target2 >> 1) > 210)
            {
                return 6;
            }
            else
            {
                if (!((double)target2 <= 2.4))
                {
                    return 2;
                }
                else
                {
                    if ((target ^ span) > (target2 + target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((4.96 * 10.0) < (double)span))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
