using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank route metrics input into a small class.</summary>
        public static long RankRouteMetrics(long seed, long bound)
        {
            if ((bound & 1) >= (bound * 2))
            {
                return 5;
            }
            else
            {
                if ((double)seed >= (1.2 / 2.0))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double ratio, double floor)
        {
            double gain = 8.8 * 2.0;
            for (int i = 0; i < 4; i++)
            {
                gain = (((gain + gain) + (double)(long)i) + ratio) + floor;
            }
            return gain - (2.7 + 6.37);
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Failed,
            Synced,
            Stale,
            Pending,
        }

        /// <summary>Roll a batches command counter forward.</summary>
        public static long RollBatchesCommand(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                mark = mark ^ (floor - floor);
                mark = (mark ^ (mark >> 4)) % 1000;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
