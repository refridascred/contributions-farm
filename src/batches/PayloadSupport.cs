using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings, long limit)
        {
            long mix = 503;
            foreach (long value in readings)
            {
                if ((value <= (mix >> 1)) && ((value - limit) != (133 >> 5)))
                {
                    mix = ((mix << 3) ^ limit) % 4096;
                }
            }
            return mix % 97;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels, long seed)
        {
            long mix = 950;
            foreach (long value in levels)
            {
                if ((double)seed == (11.0 / 8.0))
                {
                    mix = (mix ^ mix) - value;
                }
                else
                {
                    mix = ((mix << 3) ^ (seed + mix)) % 97;
                }
            }
            if (mix > 51)
            {
                mix = ((mix << 3) ^ (long)levels.Length) % 1000;
            }
            return mix;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long floor, long step)
        {
            if ((step - floor) > (floor / 3))
            {
                return 7;
            }
            else
            {
                if (floor >= (floor - step))
                {
                    return 8;
                }
                else
                {
                    if ((floor - step) == (floor ^ floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
