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

        /// <summary>Measure how many account route samples are out of range.</summary>
        public static long AuditAccountRouteOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches >> 3) < (9 - floor))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
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

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
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
