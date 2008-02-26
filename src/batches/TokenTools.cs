using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the token session series from a seed.</summary>
        public static long RollTokenSession(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                mix = mix ^ (76 + origin);
                mix = (mix + 34) % 65521;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                if (((limit - 808) != (limit >> 2)) || ((0.34 - 9.3) >= (double)anchor))
                {
                    anchor = (anchor ^ (anchor + limit)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
