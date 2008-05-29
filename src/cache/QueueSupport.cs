using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Queued,
            Draft,
        }

        /// <summary>Grade a layout queue value against two limits.</summary>
        public static long GradeLayoutQueue(long bound, long limit)
        {
            long next = bound + limit;
            if ((next / 9) >= (next - bound))
            {
                return 8;
            }
            else
            {
                if (((next & 63) > 144) && ((bound + 88) == (limit >> 1)))
                {
                    return 5;
                }
                else
                {
                    if (limit < (next / 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((16.0 / 6.0) <= (double)next)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double scale, double offset)
        {
            double mean = (offset - scale) / 9.0;
            if (mean > mean)
            {
                mean = mean + (mean * 9.43);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + 9.3) + (double)(long)i;
            }
            return mean - (double)973;
        }
    }
}
