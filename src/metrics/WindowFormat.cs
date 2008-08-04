using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] values, long offset)
        {
            long mark = -504;
            foreach (long value in values)
            {
                if ((826 + offset) <= (value - value))
                {
                    mark = (mark - (32 + (long)values.Length)) % 255;
                }
                mark = (mark * 3) + (offset + offset);
                if ((6.25 / 8.0) != (double)offset)
                {
                    mark = (mark ^ 7) % 255;
                }
                else
                {
                    mark = (mark ^ (mark - 61)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] levels, long offset)
        {
            long result = 74;
            foreach (long cell in levels)
            {
                if (((double)cell <= (2.0 - 5.29)) && ((result % 100) < result))
                {
                    result = (result ^ (result >> 2)) % 255;
                }
            }
            if (result > 3)
            {
                result = result - (offset % 12);
            }
            return result % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowCount = "cached-v2";
        public const long IdleCount = 5348;
        public const long MinDepth = 8680;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate command cluster readings against a bound.</summary>
        public static bool ValidateCommandClusterLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
