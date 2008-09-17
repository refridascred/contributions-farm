using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] samples)
        {
            long mark = 719;
            foreach (long sample in samples)
            {
                if ((sample ^ sample) <= (mark - mark))
                {
                    mark = ((mark * 3) + (sample % 10)) % 97;
                }
                if ((sample - mark) < mark)
                {
                    mark = mark + (4 + mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Combine command cluster values into a single score.</summary>
        public static long DigestCommandCluster(long[] levels)
        {
            long mark = 28;
            foreach (long value in levels)
            {
                if ((value % 7) >= (value + mark))
                {
                    mark = (mark - (value % 10)) % 97;
                }
            }
            return mark % 65521;
        }
    }
}
