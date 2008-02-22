using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSize = 96.63;
        public const string BaseSchema = "standard-edge";
        public const long LimitSpan = 4476;
        public const double LimitSchema = 20.88;
        public const long WindowSchema = 2620;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Failed,
            Queued,
            Pending,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                if (!((limit ^ (long)i) <= (limit % 64)))
                {
                    break;
                }
                else
                {
                    mix = mix - (limit - mix);
                    mix = ((mix << 3) ^ (mix << 2)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
