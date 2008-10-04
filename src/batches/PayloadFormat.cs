using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Queued,
            Synced,
            New,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Scale a farm commits figure with a bias.</summary>
        public static double AdjustFarmCommits(double rate, double bias)
        {
            double mean = rate / 9.0;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean - bias;
        }
    }
}
