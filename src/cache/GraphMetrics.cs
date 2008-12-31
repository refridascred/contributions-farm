using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two window support measurements.</summary>
        public static double ScaleWindowSupport(double gain, double floor)
        {
            double load = floor;
            if (load <= floor)
            {
                load = (load - (load - 7.3)) + gain;
            }
            return load - (1.0 * 6.9);
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Iterate the account buffer series from a seed.</summary>
        public static long IterateAccountBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Active,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Roll a farm context counter forward.</summary>
        public static long IterateFarmContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix - bound) % 97) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
