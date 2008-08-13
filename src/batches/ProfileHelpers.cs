using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample << 2) >= (sample - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next support notes value from a seed.</summary>
        public static long SeriesSupportNotes(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of batch layout entries.</summary>
        public static long CombineBatchLayout(long[] items)
        {
            long acc = 844;
            foreach (long value in items)
            {
                if ((double)acc == (double)957)
                {
                    acc = ((acc + (10 & 15)) % 255) + value;
                }
            }
            return acc;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Draft,
            Locked,
            Closed,
            Paused,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Owner { get; set; }
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }
    }
}
