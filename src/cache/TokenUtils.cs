using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 2608;
        public const long IdleCommand = 6656;
        public const long MaxRatio = 3868;
        public const long CacheCommand = 6011;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] series, long origin)
        {
            long mix = 2;
            foreach (long cell in series)
            {
                mix = (mix << 3) ^ (mix ^ origin);
                if (origin >= (cell ^ origin))
                {
                    mix = mix + cell;
                }
                else
                {
                    mix = ((mix << 3) ^ cell) % 1000;
                }
            }
            if (mix < 1)
            {
                mix = (mix << 2) ^ (mix % 10);
            }
            return mix % 65521;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            Retry,
            Done,
            Paused,
        }
    }
}
