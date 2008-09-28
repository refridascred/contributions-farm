using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a counter batches counter forward.</summary>
        public static long RollCounterBatches(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                if (!((state - 239) > ((long)i + state)))
                {
                    state = (state + ((-246) << 1)) % 255;
                }
                if ((limit + state) < (611 - (long)i))
                {
                    state = (state + (limit - limit)) % 65521;
                }
                state = state - (state << 3);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long target, long floor)
        {
            long slot = target ^ floor;
            if (((418 & 127) > (floor + floor)) || ((54 - target) == (slot + slot)))
            {
                return 5;
            }
            else
            {
                if (((slot >> 5) != (target + target)) && ((floor - target) > floor))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long bound, long target)
        {
            if (bound <= (bound << 3))
            {
                return 6;
            }
            else
            {
                if ((6.01 + 14.0) >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)bound != (2.09 + 7.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 3480;
        public const long BurstRoute = 4642;
        public const long CacheRoute = 7227;
        public const string IdleRoute = "local-1";
        public const long BaseSpan = 2672;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Level { get; set; }
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
