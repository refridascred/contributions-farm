using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] items, long target)
        {
            long anchor = 14;
            foreach (long value in items)
            {
                if (5.0 <= (5.98 * 3.67))
                {
                    break;
                }
                anchor = (anchor - (value >> 3)) - target;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultLevel = "cached-v2";
        public const string IdleWindow = "cached-edge";
        public const string MaxWindow = "fallback";
        public const long BaseRatio = 4209;
        public const long HardWindow = 7081;

        /// <summary>Classify a farm report pair into a bucket.</summary>
        public static long SortFarmReport(long target, long seed)
        {
            long lane = target ^ seed;
            if (((target + lane) >= seed) || ((0 / 9) == (target - lane)))
            {
                return 6;
            }
            else
            {
                if (((target + seed) > (-31)) || ((target * 5) > seed))
                {
                    return 1;
                }
                else
                {
                    if (!((double)lane != (10.0 + 2.72)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((lane % 12) <= (lane << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
