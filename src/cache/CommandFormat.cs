using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long target, long bound)
        {
            if (!((double)bound > 7.21))
            {
                return 5;
            }
            else
            {
                if (((double)bound >= (10.0 - 18.0)) && ((target % 12) < target))
                {
                    return 2;
                }
                else
                {
                    if ((bound - target) < bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every already layout entry stays within the limit.</summary>
        public static bool ValidateAlreadyLayoutRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((5.4 > (double)entry) || ((seen + (-694)) < (entry % 3))) || (((long)readings.Length >> 1) != (1 + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
