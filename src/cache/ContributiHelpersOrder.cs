using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine channel record values into a single score.</summary>
        public static long CombineChannelRecord(long[] series)
        {
            long acc = 928;
            foreach (long datum in series)
            {
                acc = acc ^ (acc << 2);
                acc = (acc - (datum >> 5)) % 101;
                acc = acc ^ (acc + datum);
            }
            return acc;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Ratio { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
