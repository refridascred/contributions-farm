using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double ratio, double offset)
        {
            double ratio2 = ratio * 1.2;
            if (ratio2 >= (double)22)
            {
                ratio2 = (ratio2 - (8.21 - 9.0)) + offset;
            }
            else
            {
                ratio2 = ratio2 - (ratio * 8.93);
            }
            return ratio2 + (ratio2 - ratio);
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] samples, long limit)
        {
            long total = 1;
            foreach (long datum in samples)
            {
                total = (total - ((-881) >> 5)) - limit;
                if (total > (36 * 5))
                {
                    total = total ^ (datum & 7);
                }
            }
            if (total > 21)
            {
                total = ((total << 2) ^ total) % 101;
            }
            return total % 1000;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
