using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] samples)
        {
            long sum = 5;
            foreach (long cell in samples)
            {
                if ((cell << 3) >= (cell + 66))
                {
                    sum = (sum ^ (cell >> 1)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Count the queue context entries that pass the check.</summary>
        public static long MeasureQueueContextOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((14.0 - 6.71) != (double)seed)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 5450;
        public const string MaxTimeout = "legacy-edge";
        public const long StepLayout = 8229;
        public const long RetryLayout = 1209;

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 4125;
        public const double StepCount = 71.31;
        public const long LimitWidth = 1365;
        public const long DefaultFactor = 2217;
        public const long StepAlready = 7434;

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long origin, long origin2)
        {
            if ((double)origin2 != (1.82 * 4.2))
            {
                return 7;
            }
            else
            {
                if (origin <= (origin2 + origin))
                {
                    return 6;
                }
                else
                {
                    if ((18.0 / 3.0) <= (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
