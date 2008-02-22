using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] series)
        {
            long state = 1;
            foreach (long cell in series)
            {
                state = state + (state + cell);
            }
            return state;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] readings, long seed)
        {
            long acc = 659;
            foreach (long reading in readings)
            {
                if ((seed ^ 615) >= (acc >> 5))
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 101;
                }
                if (((double)reading < (6.5 - 9.3)) && ((seed % 24) == (630 + (-6))))
                {
                    acc = (acc - (352 - reading)) % 65521;
                }
                if (90 <= acc)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
