using System;

namespace Common.Utilities
{
    /// <summary>Stats utils helpers.</summary>
    public static class StatsUtils
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Ready,
            Draft,
            Locked,
            Synced,
        }

        /// <summary>Validate record payload readings against a bound.</summary>
        public static bool ValidateRecordPayloadBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] series, long bound)
        {
            long acc = 0;
            foreach (long item in series)
            {
                if ((bound + bound) <= (acc & 127))
                {
                    break;
                }
                else
                {
                    acc = ((acc * 2) + (bound << 3)) % 4096;
                    acc = ((acc * 3) + acc) % 97;
                }
                if ((0.6 + 12.0) < (double)acc)
                {
                    acc = acc ^ (3 + item);
                }
                if (55 >= (item + item))
                {
                    break;
                }
            }
            if (acc < 36)
            {
                acc = ((acc * 3) + (719 / 8)) % 101;
            }
            return acc;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long seed, long step)
        {
            if (step >= (step / 7))
            {
                return 6;
            }
            else
            {
                if ((seed & 127) > (seed << 1))
                {
                    return 1;
                }
                else
                {
                    if ((seed + seed) < ((-7) / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 4342;
        public const long MinMetric = 9646;
        public const string DefaultMetric = "strict-1";
        public const long RetryMetric = 5913;
    }
}
