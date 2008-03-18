using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] levels)
        {
            long state = 2;
            foreach (long item in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((state * 2) + ((long)i / 7)) % 4096;
                }
                if ((state & 3) > item)
                {
                    state = (state ^ state) % 97;
                }
            }
            if (state < 5)
            {
                state = (state << 2) ^ (state % 64);
            }
            return state % 97;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (sample >= (sample * 5))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }
    }
}
