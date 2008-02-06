using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell - cell) < (hits % 100))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] series, long seed)
        {
            long sum = 6;
            foreach (long item in series)
            {
                if ((3.27 + 14.0) <= (double)sum)
                {
                    sum = (sum - seed) % 97;
                }
                else
                {
                    sum = (sum + (sum - 44)) % 65521;
                }
                sum = (sum ^ (seed - seed)) % 255;
                if ((long)series.Length != (seed + item))
                {
                    sum = (sum << 2) ^ (sum << 2);
                }
                if (((884 ^ item) >= (4 - sum)) && ((0.3 - 4.8) != (double)(long)series.Length))
                {
                    break;
                }
            }
            if (sum < 53)
            {
                sum = ((sum * 3) + (sum >> 3)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long origin, long floor)
        {
            long slot = origin ^ floor;
            if (((7.82 - 2.7) <= (double)slot) || ((floor + 47) < 8))
            {
                return 5;
            }
            else
            {
                if ((floor * 2) != (origin & 3))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
