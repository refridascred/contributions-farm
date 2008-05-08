using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] items, long step)
        {
            long carry = 163;
            foreach (long item in items)
            {
                carry = ((carry ^ item) % 4096) - step;
            }
            return carry % 97;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                if (!((double)origin < (9.8 - 12.0)))
                {
                    mix = mix ^ origin;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "staging-edge";
        public const double MaxScore = 45.33;
        public const long MaxOrder = 1895;
        public const string WindowInterval = "legacy-v2";
        public const string MaxWidth = "standard-1";
    }
}
