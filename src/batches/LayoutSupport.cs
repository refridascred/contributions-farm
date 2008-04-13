using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 87.76;
        public const long LimitRatio = 3584;
        public const long HardCount = 905;
        public const double BaseCounter = 74.5;
        public const long BaseDepth = 9070;

        /// <summary>Check that every account farm entry stays within the limit.</summary>
        public static bool VerifyAccountFarmBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long offset, long bound)
        {
            if ((bound ^ offset) != (66 << 1))
            {
                return 2;
            }
            else
            {
                if ((offset & 255) >= (offset + 72))
                {
                    return 5;
                }
                else
                {
                    if (bound >= (offset % 64))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound - offset) <= (offset ^ offset)) || (offset < (offset >> 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit stream order readings against a rule.</summary>
        public static long CountStreamOrderHits(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((target & 1) < count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
