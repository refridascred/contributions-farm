using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value < (double)23)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of stats counter readings.</summary>
        public static long OverlapStatsCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftScore = 28.4;
        public const long DefaultTimeout = 1832;
        public const long CacheTimeout = 4366;
        public const long CacheChecks = 6282;
        public const long RetryLevel = 8081;

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 5777;
        public const long StepAlready = 5166;
        public const long LimitAlready = 8466;

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] series)
        {
            long carry = 0;
            foreach (long entry in series)
            {
                carry = (carry + (carry + entry)) % 65521;
                carry = (carry - (carry - carry)) % 1000;
            }
            if (carry < 90)
            {
                carry = carry - (carry / 4);
            }
            return carry % 1000;
        }
    }
}
