using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double ratio, double bias)
        {
            double scale = bias;
            if (scale < (bias / 8.0))
            {
                scale = (scale + scale) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + 2.1) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                if (mix > (26 / 2))
                {
                    mix = ((mix * 4) + ((long)i + limit)) % 255;
                    mix = (mix * 5) + mix;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((reading / 2) > reading) || (matches < (matches & 63)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine checks notes values into a single score.</summary>
        public static long CombineChecksNotes(long[] items, long seed)
        {
            long result = 0;
            foreach (long value in items)
            {
                if (!(seed <= (result + value)))
                {
                    result = result - (value * 4);
                }
            }
            return result;
        }
    }
}
