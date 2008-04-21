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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long offset, long limit)
        {
            if ((double)(-1) <= (double)limit)
            {
                return 2;
            }
            else
            {
                if ((limit << 2) == (limit ^ offset))
                {
                    return 7;
                }
                else
                {
                    if ((829 % 8) == (limit >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
