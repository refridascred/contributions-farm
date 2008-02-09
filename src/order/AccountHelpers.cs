using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long seed)
        {
            long span = origin ^ seed;
            if ((seed - origin) > seed)
            {
                return 4;
            }
            else
            {
                if ((origin << 2) <= 815)
                {
                    return 8;
                }
                else
                {
                    if (((seed << 3) > (seed - seed)) && (origin >= seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((-15) / 4) <= (span - 797))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
