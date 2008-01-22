using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 8745;
        public const long DefaultDepth = 4003;
        public const string LimitSession = "fallback-1";

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long seed, long target)
        {
            if ((seed & 31) != (seed + target))
            {
                return 6;
            }
            else
            {
                if ((target * 2) < (seed - target))
                {
                    return 0;
                }
                else
                {
                    if ((3 + seed) >= (target / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target >= (seed - seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank commits window input into a small class.</summary>
        public static long SortCommitsWindow(long floor, long floor2)
        {
            if (!(floor > (floor2 & 255)))
            {
                return 0;
            }
            else
            {
                if ((floor2 + floor) >= ((-6) % 8))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry ^ tally) >= (tally + (-35)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
