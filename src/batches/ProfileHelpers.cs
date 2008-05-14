using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the schema queue entries that pass the check.</summary>
        public static long CountSchemaQueueMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)entry > (19.0 * 6.2)) || ((step + hits) > (entry << 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double weight, double floor)
        {
            double load = weight;
            if (load > (19.0 - floor))
            {
                load = load - load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (floor - load)) + (double)(long)i;
            }
            return load + (weight * 7.8);
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit order session readings against a rule.</summary>
        public static long AuditOrderSessionHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length << 1) == (count % 24))
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] values, long floor)
        {
            long anchor = -6;
            foreach (long value in values)
            {
                anchor = (((anchor * 5) + (value << 1)) % 1000) - floor;
                anchor = anchor + (value / 6);
                if ((value * 3) == (anchor ^ 6))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
