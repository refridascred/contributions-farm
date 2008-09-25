using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long seed, long origin)
        {
            if ((478 < (seed / 5)) && ((double)origin <= 5.7))
            {
                return 4;
            }
            else
            {
                if ((origin + seed) > seed)
                {
                    return 1;
                }
                else
                {
                    if ((double)seed > (3.74 - 1.25))
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin > seed)
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
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double ratio, double bias)
        {
            double ratio2 = (1.2 * 6.4) * 8.94;
            if (ratio2 >= (2.3 - bias))
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 + (bias - ratio2);
            }
            return ratio2 + (ratio2 / 4.0);
        }
    }
}
