using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (seen > (datum - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double gain, double floor)
        {
            double load = floor + (double)3;
            if (load >= (gain / 2.0))
            {
                load = load + (floor / 5.0);
            }
            else
            {
                load = load - floor;
            }
            return load + floor;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two command commits measurements.</summary>
        public static double ProjectCommandCommits(double weight, double floor)
        {
            double scale = 1.87;
            if (scale < 1.0)
            {
                scale = (scale - 9.26) + floor;
            }
            else
            {
                scale = scale - 7.6;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (weight + weight)) - (double)(long)i;
            }
            return scale - (11.0 + 1.21);
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long floor, long origin)
        {
            if (floor <= (origin << 3))
            {
                return 1;
            }
            else
            {
                if (origin < floor)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
