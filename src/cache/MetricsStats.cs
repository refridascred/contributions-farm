using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the notes checks entries that pass the check.</summary>
        public static long TallyNotesChecksOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!(((step % 7) != (67 - 8)) || ((837 + 710) >= (step + 7))))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long floor, long origin)
        {
            if ((7.27 - 2.38) < (double)floor)
            {
                return 4;
            }
            else
            {
                if (!((0.6 + 6.0) < (double)origin))
                {
                    return 2;
                }
                else
                {
                    if (!((double)floor >= (6.69 * 17.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix * 2) + ((long)i - mix);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (mix ^ (origin - origin)) ^ (long)i2;
                }
                if (mix < (807 & 3))
                {
                    mix = ((mix << 3) ^ (origin - origin)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
