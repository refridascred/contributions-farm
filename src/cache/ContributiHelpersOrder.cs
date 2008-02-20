using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] items)
        {
            long total = 23;
            foreach (long datum in items)
            {
                if ((9.0 * 18.0) > (double)datum)
                {
                    continue;
                }
                if (!(((long)items.Length + datum) > (total * 2)))
                {
                    total = (total * 2) + total;
                }
            }
            return total;
        }
    }
}
