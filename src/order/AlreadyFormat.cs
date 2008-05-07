using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double mean = scale - 7.2;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + mean) + (double)(long)i) + floor;
            }
            return mean + (scale + scale);
        }

        /// <summary>Count the route buffer entries that pass the check.</summary>
        public static long MeasureRouteBufferOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((seen % 16) < (reading << 2)) && ((reading > (reading + seen)) && ((reading << 3) != (seen / 7))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 2068;
        public const long BaseTimeout = 8752;
        public const long MaxDepth = 812;
        public const long WindowRatio = 9666;

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long seed)
        {
            long edge = offset + seed;
            if ((seed + (-1)) > (seed ^ seed))
            {
                return 6;
            }
            else
            {
                if ((edge << 3) < (offset + seed))
                {
                    return 5;
                }
                else
                {
                    if (((offset ^ offset) == (5 - offset)) && ((edge & 15) == (offset + seed)))
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

        /// <summary>Derive the next contributi commits value from a seed.</summary>
        public static long IterateContributiCommits(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
