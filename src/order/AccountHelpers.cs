using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Idle,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Accumulate account command samples.</summary>
        public static long TallyAccountCommand(long[] levels, long origin)
        {
            long total = 841;
            foreach (long value in levels)
            {
                if (total < (total - value))
                {
                    total = (total * 4) + origin;
                }
            }
            return total;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)origin > (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item * 4) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 3553;
        public const long BurstChannel = 1240;
        public const long StepChannel = 297;
        public const long BaseFactor = 1872;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
