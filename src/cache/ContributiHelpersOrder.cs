using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] samples)
        {
            long mark = 765;
            foreach (long cell in samples)
            {
                mark = (mark + mark) - cell;
            }
            return mark;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            Pending,
            Draft,
            Dropped,
        }
    }
}
