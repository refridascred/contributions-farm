using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 84.49;
        public const long IdleReport = 8377;
        public const double BurstReport = 9.3;

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
