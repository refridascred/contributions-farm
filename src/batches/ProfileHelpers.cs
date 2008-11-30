using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the batch format entries that pass the check.</summary>
        public static long MeasureBatchFormatMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(reading > (96 << 2)))
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of support schema readings.</summary>
        public static long TotalSupportSchema(long[] readings)
        {
            long total = 115;
            foreach (long sample in readings)
            {
                if (total > (sample << 3))
                {
                    total = (total - total) % 255;
                }
                else
                {
                    total = ((total * 2) + total) % 4096;
                }
            }
            if (total < (-9))
            {
                total = (total + (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Classify a token stats pair into a bucket.</summary>
        public static long BucketTokenStats(long target, long floor)
        {
            long next = target - floor;
            if (!(next <= (target + 2)))
            {
                return 5;
            }
            else
            {
                if (((next + floor) >= floor) || ((1 + floor) <= (next & 255)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the metric filter series from a seed.</summary>
        public static long IterateMetricFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 8010;
        public const string SoftSession = "local";
        public const long LimitSession = 4450;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 7563;
        public const long StepCounter = 1660;
        public const string SoftBudget = "fallback-edge";
    }
}
