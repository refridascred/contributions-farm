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

        /// <summary>Iterate the command contributi series from a seed.</summary>
        public static long RollCommandContributi(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
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
