using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum << 2) ^ ((long)i << 2)) % 101;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public double Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double ratio, double span)
        {
            double rate = (double)(543 * 2);
            return ((rate + rate) + ratio) + span;
        }
    }
}
