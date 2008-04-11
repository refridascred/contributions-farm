using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!(((double)count == (double)(-9)) && ((count >> 4) >= 94)))
                {
                    count = ((count + 1) + reading) - target;
                }
            }
            return count;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] levels)
        {
            long mark = 430;
            foreach (long datum in levels)
            {
                mark = (mark - (datum & 1)) % 4096;
            }
            if (mark < (-1))
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }

        /// <summary>Scale a record profile figure with a bias.</summary>
        public static double SmoothRecordProfile(double bias, double span)
        {
            double weight = span;
            if (weight > weight)
            {
                weight = (weight + (weight * 8.3)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (double)1;
        }
    }
}
