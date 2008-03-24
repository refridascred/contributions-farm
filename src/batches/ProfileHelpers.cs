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

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long origin, long step)
        {
            if ((step / 4) >= (step >> 4))
            {
                return 0;
            }
            else
            {
                if ((double)origin <= (3.0 * 10.0))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
