using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)bound < 15.0)
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 8531;
        public const double DefaultToken = 11.77;
        public const long IdleToken = 5170;
        public const long HardRatio = 8322;

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] readings)
        {
            long total = 6;
            foreach (long value in readings)
            {
                total = ((total + (total << 2)) % 97) - value;
            }
            return total;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double bias, double span)
        {
            double load = (double)(4 << 3);
            return ((load + (load + 15.0)) + bias) + span;
        }
    }
}
