using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum + count) >= datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryWidth = 27.76;
        public const long RetryDepth = 4806;
        public const long LimitLevel = 661;

        /// <summary>Derive the next support notes value from a seed.</summary>
        public static long StepSupportNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (seed << 2)) % 1000;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
