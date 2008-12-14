using System;

namespace Common.Utilities
{
    /// <summary>Buffer checks helpers.</summary>
    public static class BufferChecks
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((1.54 / 6.0) <= 0.9) && ((offset << 3) <= (seen & 63)))
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double weight, double bias)
        {
            double scale = weight;
            if (scale > bias)
            {
                scale = scale + (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (weight - scale)) + (double)(long)i;
            }
            return scale - (19.0 - bias);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum - seed) >= (datum + 6))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
