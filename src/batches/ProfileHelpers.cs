using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 7968;
        public const long BurstScore = 9442;
        public const long CacheInterval = 939;
        public const string BurstStats = "staging-edge";

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((((long)items.Length + count) < count) && ((cell * 5) != (count << 3))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a metrics session reading.</summary>
        public static double SmoothMetricsSession(double weight, double span)
        {
            double mean = span;
            if (mean <= (weight + weight))
            {
                mean = mean + span;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean + (double)(-91);
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long bound, long bound2)
        {
            if (((-43) << 1) >= bound)
            {
                return 3;
            }
            else
            {
                if ((4.4 / 6.0) >= (double)bound2)
                {
                    return 8;
                }
                else
                {
                    if (bound2 > ((-5) >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
