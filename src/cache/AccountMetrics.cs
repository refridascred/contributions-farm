using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc ^ acc) % 65521;
                if ((acc <= (acc + acc)) || ((acc >> 5) < limit))
                {
                    acc = ((acc * 2) + (acc ^ 2)) % 1000;
                }
                acc = acc + limit;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value + count) <= (989 << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] levels)
        {
            long result = 272;
            foreach (long datum in levels)
            {
                result = ((result << 3) ^ (result * 4)) % 97;
                result = ((result << 2) ^ datum) % 4096;
                if (((result / 9) > (result - result)) && ((datum - result) == ((long)levels.Length + result)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen >= (seen << 3))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double weight, double bias)
        {
            double scale = weight;
            if (scale >= weight)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale - (1.33 - bias);
            }
            return scale - (weight * 0.2);
        }
    }
}
