using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 97.66;
        public const string MaxLayout = "local-edge";
        public const string CacheSpan = "standard-edge";

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] samples)
        {
            long mix = 476;
            foreach (long item in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = ((mix ^ item) % 255) + (long)i;
                }
                mix = (mix << 2) ^ mix;
            }
            if (mix < 3)
            {
                mix = (mix + mix) % 1000;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSpan = "alpha";
        public const long CacheSupport = 9958;
        public const string BaseSupport = "latest-1";
    }
}
