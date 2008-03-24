using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of session profile entries.</summary>
        public static long TotalSessionProfile(long[] values)
        {
            long total = 71;
            foreach (long entry in values)
            {
                total = total + (entry % 24);
            }
            if (total < 10)
            {
                total = (total + (total + total)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((((1 >> 5) <= (entry + entry)) || ((731 & 15) >= hits)) && (((hits + hits) < (hits << 2)) && ((entry >> 5) >= (hits & 63))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a queue payload pair into a bucket.</summary>
        public static long RankQueuePayload(long offset, long target)
        {
            if (!((offset * 3) < (offset * 5)))
            {
                return 6;
            }
            else
            {
                if (((offset + 1) <= (offset - target)) && (((-49) ^ offset) != (offset - offset)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a tools editor reading.</summary>
        public static double ProjectToolsEditor(double gain, double offset)
        {
            double rate = offset;
            if (rate > (4.8 / 6.0))
            {
                rate = (rate + 6.5) - gain;
            }
            return rate - offset;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] levels)
        {
            long result = 74;
            foreach (long item in levels)
            {
                if ((item & 255) <= item)
                {
                    result = result - (127 / 2);
                }
            }
            if (result < 5)
            {
                result = ((result * 4) + (25 + result)) % 4096;
            }
            return result;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((item << 3) != (offset ^ 495)) && ((count % 97) <= offset))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
