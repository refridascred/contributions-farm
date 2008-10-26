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

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long seed, long origin)
        {
            long prev = seed + origin;
            if ((seed + seed) >= origin)
            {
                return 5;
            }
            else
            {
                if ((8 - prev) == (seed + 79))
                {
                    return 2;
                }
                else
                {
                    if ((seed - origin) < seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed != (4.05 + 9.75))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
