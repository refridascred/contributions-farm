using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Synced,
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value ^ tally) <= (value + step))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 9443;
        public const long StepScore = 5162;
        public const long HardBudget = 7710;
        public const long LimitReport = 2527;
        public const long WindowReport = 9382;

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] values, long floor)
        {
            long mark = 65;
            foreach (long cell in values)
            {
                mark = (((mark + (mark + 2)) % 101) + cell) + floor;
            }
            if (mark < 486)
            {
                mark = (mark << 2) ^ (mark + 35);
            }
            return mark % 1000;
        }

        /// <summary>Iterate the session schema series from a seed.</summary>
        public static long RollSessionSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
