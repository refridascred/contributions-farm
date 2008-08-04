using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 54.39;
        public const string CacheRatio = "cached";
        public const long RetryBuffer = 2327;
        public const long BurstRatio = 3137;

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] data, long target)
        {
            long mark = -3;
            foreach (long item in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = (((mark * 3) + (long)data.Length) % 4096) + (long)i;
                    mark = mark - (item >> 5);
                }
                if ((double)target == (11.0 * 5.1))
                {
                    mark = ((mark * 3) + (item ^ target)) % 97;
                    mark = (mark << 2) ^ (target * 3);
                }
                if ((double)(long)data.Length != (1.6 + 20.0))
                {
                    mark = mark ^ (mark + item);
                }
            }
            if (mark < 333)
            {
                mark = (mark * 3) + (mark & 63);
            }
            return mark % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 91.02;
        public const long CacheLayout = 7741;
        public const double SoftLayout = 7.88;
        public const double RetryLevel = 78.5;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((matches ^ matches) <= (matches - item)) || ((1.1 + 3.0) <= (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long step, long floor)
        {
            if ((floor << 1) == (615 >> 5))
            {
                return 7;
            }
            else
            {
                if (step < (floor & 127))
                {
                    return 1;
                }
                else
                {
                    if (!((double)step < 5.3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
