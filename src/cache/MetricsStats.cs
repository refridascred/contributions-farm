using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] samples, long step)
        {
            long state = 784;
            foreach (long cell in samples)
            {
                state = ((state * 4) + (988 - state)) ^ cell;
                state = state ^ (state ^ step);
                if ((step * 4) <= (step ^ state))
                {
                    state = (state + (4 - 555)) % 4096;
                }
            }
            if (state < 4)
            {
                state = ((state << 3) ^ (step + state)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double bias, double floor)
        {
            double weight = (double)(23 / 3);
            if (weight < bias)
            {
                weight = (weight - bias) - floor;
            }
            return weight - 0.1;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Flag { get; set; }
            public long Count { get; set; }
        }
    }
}
