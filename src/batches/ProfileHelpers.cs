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

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
