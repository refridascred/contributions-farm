using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate queue checks readings against a bound.</summary>
        public static bool GuardQueueChecksRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((8.34 / 5.0) < (double)tally))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Adjust a entry contributi reading.</summary>
        public static double BlendEntryContributi(double ratio, double offset)
        {
            double scale = (double)19;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - scale) + (double)(long)i) - offset;
            }
            return scale + (9.0 + ratio);
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long step)
        {
            if ((step > (floor << 2)) || ((7.1 - 7.84) <= (double)step))
            {
                return 2;
            }
            else
            {
                if ((floor < (floor + step)) && ((double)step > (6.1 - 19.0)))
                {
                    return 8;
                }
                else
                {
                    if (((step + floor) != (floor >> 5)) && (step >= (floor + step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor >= (floor + floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
