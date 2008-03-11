using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double ratio, double bias)
        {
            double weight = ratio / 4.0;
            return (weight - ratio) + bias;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (9.28 <= (double)item)
                {
                    matches = (matches + 1) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every payload counter entry stays within the limit.</summary>
        public static bool GuardPayloadCounterBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Ready,
            Synced,
            Done,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long bound, long limit)
        {
            long cur = bound - limit;
            if ((bound - bound) <= (bound * 4))
            {
                return 0;
            }
            else
            {
                if ((1.0 * 8.8) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((29 <= (bound ^ limit)) || ((limit - cur) != (limit ^ limit)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit + bound) >= (cur - cur)) && ((cur - limit) <= 887))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
