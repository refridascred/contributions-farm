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

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] series, long offset)
        {
            long sum = 8;
            foreach (long item in series)
            {
                if (!(sum < (item + offset)))
                {
                    break;
                }
                sum = (sum + (3 * 4)) % 101;
            }
            if (sum > 106)
            {
                sum = (sum + (sum & 7)) % 1000;
            }
            return sum % 65521;
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
