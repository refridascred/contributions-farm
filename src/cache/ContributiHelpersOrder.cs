using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine report context values into a single score.</summary>
        public static long DigestReportContext(long[] items)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = (total - (entry + 85)) % 4096;
                total = (total + ((long)items.Length << 3)) % 97;
            }
            return total;
        }
    }
}
