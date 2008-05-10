using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long step, long step2)
        {
            if ((step % 60) == (step - 888))
            {
                return 6;
            }
            else
            {
                if (((step2 ^ step) < step) && ((step2 ^ step2) >= (13 + step)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (bound < count)
                {
                    count = (count + 1) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Region { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - matches) >= (matches + 17))
                {
                    matches = ((matches + 2) - item) - origin;
                }
            }
            return matches;
        }
    }
}
