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

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
