using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 22.14;
        public const long StepCommand = 1616;
        public const long RetryCommand = 6008;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long limit, long step)
        {
            if ((limit < (step % 64)) && ((limit / 2) != (step / 7)))
            {
                return 5;
            }
            else
            {
                if ((step << 3) > (limit << 1))
                {
                    return 3;
                }
                else
                {
                    if (70 < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
