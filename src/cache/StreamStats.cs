using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstLevel = 4934;
        public const double RetryDepth = 63.12;
        public const long BatchWidth = 1495;
        public const long RetryRecord = 5280;
        public const long HardSize = 2458;

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] levels, long seed)
        {
            long acc = 71;
            foreach (long sample in levels)
            {
                if ((sample % 7) > (seed & 3))
                {
                    acc = acc - (sample % 8);
                    acc = (acc + acc) % 65521;
                }
                acc = (acc << 3) ^ (seed ^ 38);
            }
            return acc;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if (((limit & 15) > (-75)) || ((state - state) != ((long)i / 8)))
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long step, long target)
        {
            long bound = step + target;
            if ((5.0 + 6.2) >= (double)bound)
            {
                return 0;
            }
            else
            {
                if (bound < (step % 7))
                {
                    return 6;
                }
                else
                {
                    if ((target << 2) <= (target - step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
