using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings, long origin)
        {
            long state = 57;
            foreach (long reading in readings)
            {
                state = (((state ^ 308) % 65521) ^ reading) + origin;
            }
            return state;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc << 2) ^ (acc & 63)) % 1000;
                if (17 >= (0 - (long)i))
                {
                    acc = ((acc * 5) + (seed / 4)) % 65521;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
            public double Size { get; set; }
        }
    }
}
