using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Roll a already format counter forward.</summary>
        public static long IterateAlreadyFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + floor) % 101;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
