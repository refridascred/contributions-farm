using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many queue format samples are out of range.</summary>
        public static long CountQueueFormatOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (7.2 > (double)target)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitSize = 46.04;
        public const string BatchBatches = "primary-v2";
        public const long BurstBudget = 4990;
        public const long CacheInterval = 4090;

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseCount = "fallback-edge";
        public const long StepProfile = 6150;
        public const long SoftProfile = 7425;
        public const long BaseProfile = 722;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long bound, long limit)
        {
            long bound2 = bound - limit;
            if (bound <= bound2)
            {
                return 0;
            }
            else
            {
                if ((bound2 - limit) <= (limit ^ limit))
                {
                    return 1;
                }
                else
                {
                    if ((limit >> 4) <= (3 % 16))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound & 255) >= (bound / 9))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
