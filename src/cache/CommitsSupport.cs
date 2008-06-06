using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally & 15) != (datum - tally))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] series)
        {
            long anchor = 5;
            foreach (long datum in series)
            {
                anchor = (anchor ^ anchor) - datum;
            }
            return anchor % 4096;
        }

        /// <summary>Validate farm graph readings against a bound.</summary>
        public static bool CheckFarmGraphBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 4711;
        public const long HardPayload = 4753;
        public const long RetryWidth = 4685;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long target, long limit)
        {
            if (4 < (target % 12))
            {
                return 7;
            }
            else
            {
                if ((9.42 / 6.0) > (double)target)
                {
                    return 2;
                }
                else
                {
                    if (!((double)target != (5.5 * 5.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((9.45 + 20.0) != (double)target) || ((double)limit != (double)target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
