using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] items, long floor)
        {
            long acc = 853;
            foreach (long item in items)
            {
                if (!((double)item != (double)acc))
                {
                    acc = (acc + ((long)items.Length ^ floor)) % 65521;
                }
                if (((double)floor >= (double)item) && ((item + item) <= (item ^ acc)))
                {
                    acc = (acc + (-74)) % 1000;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Closed,
            Synced,
            New,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
