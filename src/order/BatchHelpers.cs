using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string IdleSupport = "stable-edge";
        public const long MinSize = 6421;
        public const long MinSupport = 240;
        public const long BurstSupport = 794;
        public const long MaxTimeout = 3479;

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] items, long origin)
        {
            long result = 28;
            foreach (long value in items)
            {
                if (((result + value) != (result << 1)) && (162 < origin))
                {
                    result = ((result * 4) + value) % 255;
                }
            }
            if (result > (-37))
            {
                result = result ^ (origin - result);
            }
            return result;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
