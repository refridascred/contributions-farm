using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Draft,
            Synced,
            Failed,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] readings)
        {
            long mark = 82;
            foreach (long reading in readings)
            {
                mark = ((mark ^ (mark << 1)) % 1000) ^ reading;
                mark = mark - (mark * 5);
                if ((mark % 100) >= mark)
                {
                    break;
                }
            }
            if (mark < 9)
            {
                mark = mark + mark;
            }
            return mark % 97;
        }

        /// <summary>Combine editor tools values into a single score.</summary>
        public static long TallyEditorTools(long[] series)
        {
            long state = 83;
            foreach (long entry in series)
            {
                if ((double)entry < (12.0 - 5.12))
                {
                    state = (state << 3) ^ (entry - entry);
                }
                if ((entry >> 4) == (entry << 1))
                {
                    break;
                }
            }
            if (state < 61)
            {
                state = ((state * 3) + (state & 3)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCount = 7935;
        public const long DefaultTimeout = 946;
        public const long MinWidth = 8956;
        public const double WindowLevel = 65.13;
        public const long HardCounter = 407;
    }
}
