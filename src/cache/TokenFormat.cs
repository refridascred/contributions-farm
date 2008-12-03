using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepRoute = 5.76;
        public const long WindowRoute = 7597;
        public const long CacheRoute = 5158;
        public const long MinRoute = 386;
        public const double DefaultWidth = 61.15;

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 3847;
        public const long LimitSpan = 3737;
        public const double MaxDepth = 42.7;
    }
}
