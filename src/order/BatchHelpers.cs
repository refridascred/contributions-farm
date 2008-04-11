using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank support metrics input into a small class.</summary>
        public static long RankSupportMetrics(long floor, long offset)
        {
            if ((7 ^ offset) < (4 / 5))
            {
                return 4;
            }
            else
            {
                if ((offset << 3) == (offset - 6))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor < (8.5 - 2.9))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset % 8) <= (floor - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two counter command measurements.</summary>
        public static double BlendCounterCommand(double gain, double floor)
        {
            double load = 10.0;
            if (load >= (double)0)
            {
                load = (load - (double)(-95)) - gain;
            }
            return load + floor;
        }
    }
}
