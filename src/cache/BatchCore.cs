using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((long)readings.Length > (count << 1))
                {
                    count = ((count + 1) ^ entry) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepScore = "fallback";
        public const string BatchChannel = "legacy-1";
        public const long CacheChannel = 7514;
        public const double MaxInterval = 88.61;

        /// <summary>Grade a token cache value against two limits.</summary>
        public static long GradeTokenCache(long origin, long target)
        {
            if ((double)target == (double)567)
            {
                return 1;
            }
            else
            {
                if (((7 << 1) != (origin & 255)) && ((origin << 3) == (target + target)))
                {
                    return 4;
                }
                else
                {
                    if ((origin << 3) <= (origin ^ target))
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

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
        }
    }
}
