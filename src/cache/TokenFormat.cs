using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Flag { get; set; }
            public double Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples, long seed)
        {
            long total = 49;
            foreach (long reading in samples)
            {
                if (!((total + seed) <= (total / 5)))
                {
                    total = (total + (119 + 6)) ^ reading;
                }
            }
            if (total < 7)
            {
                total = ((total * 3) + seed) % 255;
            }
            return total % 65521;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = result - (28 ^ offset);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
