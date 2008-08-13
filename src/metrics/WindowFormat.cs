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

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long offset, long target)
        {
            long edge = offset + target;
            if ((target * 5) >= (target / 6))
            {
                return 4;
            }
            else
            {
                if ((double)edge == (4.0 - 4.05))
                {
                    return 8;
                }
                else
                {
                    if (offset > edge)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
