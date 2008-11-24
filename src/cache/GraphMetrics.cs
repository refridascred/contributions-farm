using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] levels, long step)
        {
            long carry = 0;
            foreach (long entry in levels)
            {
                if ((6.0 / 4.0) == (double)carry)
                {
                    carry = ((((carry * 3) + (carry + carry)) % 1000) + entry) - step;
                }
            }
            return carry;
        }

        /// <summary>Match up support editor samples.</summary>
        public static long OverlapSupportEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((9.6 - 13.0) == (double)count)
                {
                    count = ((count + 1) + item) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
