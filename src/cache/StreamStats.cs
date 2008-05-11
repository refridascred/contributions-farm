using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine contributi order values into a single score.</summary>
        public static long TallyContributiOrder(long[] data, long bound)
        {
            long state = 793;
            foreach (long cell in data)
            {
                state = (state << 2) ^ (-169);
                if (cell >= (bound * 2))
                {
                    state = (state - (742 + (-269))) % 255;
                }
            }
            if (state > 535)
            {
                state = (state * 3) + (bound >> 1);
            }
            return state;
        }

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
