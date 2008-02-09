using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] values)
        {
            long total = 831;
            foreach (long reading in values)
            {
                if (5.7 >= (double)reading)
                {
                    total = (total - (650 + reading)) % 255;
                }
            }
            return total;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double scale, double floor)
        {
            double load = (double)111 + (floor / 2.0);
            if (load <= 1.3)
            {
                load = (load - floor) + scale;
            }
            return load - (double)48;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((entry - 59) == (8 / 5)) && ((entry << 3) != (hits + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 9995;
        public const string LimitSpan = "strict-edge";
        public const long WindowCounter = 5206;
        public const long RetryCounter = 5200;

        /// <summary>Audit cache context readings against a rule.</summary>
        public static long MeasureCacheContextOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell + 45) >= (cell * 2))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((5.47 - 2.0) != (double)mark)
                {
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
