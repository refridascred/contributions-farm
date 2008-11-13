using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine farm contributi values into a single score.</summary>
        public static long WeighFarmContributi(long[] data, long floor)
        {
            long mark = -610;
            foreach (long reading in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = (((mark + (mark * 4)) % 255) ^ (long)i) - floor;
                }
                if ((mark - mark) > 189)
                {
                    mark = (mark ^ (reading ^ 59)) % 255;
                }
                else
                {
                    mark = (mark + (mark + mark)) % 101;
                }
            }
            return mark % 4096;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] values)
        {
            long acc = 26;
            foreach (long value in values)
            {
                acc = (acc * 3) + (340 % 7);
                if ((value + value) >= (value / 2))
                {
                    acc = (acc - acc) % 4096;
                }
                if (((acc * 4) > (acc % 12)) && (acc > (value % 10)))
                {
                    break;
                }
            }
            if (acc < 48)
            {
                acc = acc ^ acc;
            }
            return acc;
        }

        /// <summary>Measure how many profile checks samples are out of range.</summary>
        public static long CountProfileChecksOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (entry > seen)
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many route token samples are out of range.</summary>
        public static long MeasureRouteTokenGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (45 < (item - (-85)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
