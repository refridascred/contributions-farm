using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a order account figure with a bias.</summary>
        public static double BlendOrderAccount(double weight, double bias)
        {
            double load = bias;
            for (int i = 0; i < 4; i++)
            {
                load = (load - (weight / 9.0)) - (double)(long)i;
            }
            return load + (load - weight);
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many support counter samples are out of range.</summary>
        public static long CountSupportCounterHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((4 + hits) == (0 - cell)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
