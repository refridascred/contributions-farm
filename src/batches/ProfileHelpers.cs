using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultTimeout = 6565;
        public const long HardCache = 9107;
        public const long LimitScore = 7348;
        public const double BurstScore = 20.09;
        public const double LimitCache = 87.52;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values)
        {
            long mark = 8;
            foreach (long value in values)
            {
                if ((double)987 >= (double)16)
                {
                    mark = ((mark * 4) + (467 << 1)) % 1000;
                }
                if (((mark + value) == (value ^ mark)) || ((mark << 3) != (64 % 2)))
                {
                    break;
                }
            }
            if (mark > 644)
            {
                mark = (mark - (mark - mark)) % 255;
            }
            return mark % 4096;
        }
    }
}
