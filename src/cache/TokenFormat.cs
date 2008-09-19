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

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score ^ (target - score)) % 65521) ^ (long)i2;
                    score = (score ^ ((long)i + target)) % 255;
                }
                for (int i3 = 0; i3 < 9; i3++)
                {
                    score = (score + (1 >> 5)) - (long)i3;
                    score = (score - (55 + (-6))) % 1000;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
