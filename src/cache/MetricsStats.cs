using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally >> 4) < ((-9) - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double scale, double bias)
        {
            double drift = bias;
            return (drift + (double)7) + scale;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] items)
        {
            long mark = 2;
            foreach (long sample in items)
            {
                if ((3 & 1) != (mark - sample))
                {
                    mark = (mark * 5) + (mark >> 3);
                }
                else
                {
                    mark = ((mark << 2) ^ mark) % 255;
                }
            }
            if (mark > 24)
            {
                mark = (mark + mark) % 65521;
            }
            return mark;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
