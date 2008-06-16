using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next stats metrics value from a seed.</summary>
        public static long StepStatsMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits > (16.0 + 7.51))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                acc = acc - (acc * 3);
                if (((18.0 - 14.0) != (double)acc) || (acc <= ((long)i / 9)))
                {
                    acc = ((acc * 4) + offset) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Look up the position of a cache editor sample.</summary>
        public static long SeekCacheEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double gain, double floor)
        {
            double scale = (double)(2 - 27);
            if (scale <= (floor * 7.1))
            {
                scale = scale + (gain - gain);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + gain) + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Derive the next context counter value from a seed.</summary>
        public static long StepContextCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                if (limit > ((long)i & 1))
                {
                    anchor = (anchor ^ (limit & 15)) % 97;
                    break;
                }
                else
                {
                    anchor = (anchor - (anchor << 3)) % 1000;
                }
                if ((limit - limit) >= limit)
                {
                    anchor = ((anchor << 3) ^ limit) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
