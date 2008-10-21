using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a farm context counter forward.</summary>
        public static long SeriesFarmContext(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix ^ (55 - mix)) % 255) ^ (long)i2;
                }
                mix = ((mix * 5) + ((long)i * 4)) % 4096;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
