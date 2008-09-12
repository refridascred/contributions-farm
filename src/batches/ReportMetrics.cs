using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((4.9 / 3.0) >= (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long target, long target2)
        {
            long diff = target ^ target2;
            if (!((target & 15) != (diff * 3)))
            {
                return 1;
            }
            else
            {
                if ((diff + target) == (target2 & 7))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
