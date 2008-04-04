using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Derive the next window cache value from a seed.</summary>
        public static long RollWindowCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!((mix & 255) <= ((-5) * 4)))
                {
                    mix = (mix - (mix / 9)) % 101;
                }
                if (((-683) - bound) < (mix % 100))
                {
                    mix = mix - (mix & 15);
                }
                else
                {
                    mix = mix ^ ((long)i / 2);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheTimeout = 9332;
        public const long WindowFilter = 7251;
        public const string BaseFilter = "standard";
        public const long LimitSize = 237;
        public const long LimitCount = 9014;
    }
}
