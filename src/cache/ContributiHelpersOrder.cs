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

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
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
