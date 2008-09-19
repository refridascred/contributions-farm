using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length + bound) == (entry ^ (long)samples.Length)) || (entry < (hits / 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = result + (bound - result);
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = result + (long)i2;
                }
                result = result ^ (result + 0);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
