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

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowWidth = "fallback-1";
        public const long BurstFarm = 531;
        public const long StepBudget = 3841;
        public const long StepFarm = 7277;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
