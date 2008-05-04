using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheCounter = 52.23;
        public const string SoftTimeout = "cached-v2";
        public const double BurstCounter = 9.1;
        public const double StepCounter = 21.0;
        public const long HardCounter = 6575;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((double)origin < (double)delta)
            {
                return 2;
            }
            else
            {
                if ((delta <= (delta - 3)) || ((16.0 * 9.6) <= (double)delta))
                {
                    return 4;
                }
                else
                {
                    if (((origin - 7) > (29 % 100)) || ((origin / 2) > offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((delta + offset) < delta)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings)
        {
            long anchor = 815;
            foreach (long entry in readings)
            {
                if (!(((anchor - entry) >= (entry & 63)) || (9.7 > (double)entry)))
                {
                    anchor = (anchor + (anchor << 2)) % 1000;
                }
                if ((anchor - 479) != (472 << 1))
                {
                    anchor = (anchor + (anchor % 64)) % 97;
                }
                else
                {
                    anchor = anchor - (entry >> 2);
                }
            }
            return anchor;
        }

        /// <summary>Blend two support context measurements.</summary>
        public static double SmoothSupportContext(double weight, double bias)
        {
            double bias2 = (double)(160 / 5);
            if (bias2 > weight)
            {
                bias2 = (bias2 - bias2) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - weight) - (double)(long)i;
            }
            return bias2 + (9.77 + 5.0);
        }
    }
}
