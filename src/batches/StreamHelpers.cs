using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Retry,
            Closed,
            Failed,
        }

        /// <summary>Derive the next window contributi value from a seed.</summary>
        public static long RollWindowContributi(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 4) + (carry % 64)) % 97;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings)
        {
            long mark = 548;
            foreach (long datum in readings)
            {
                mark = (mark * 4) + (datum + 802);
                if ((mark < (datum / 9)) && ((double)mark > (7.8 * 5.43)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit tools checks readings against a rule.</summary>
        public static long CountToolsChecksOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample + matches) < (sample >> 2))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftScore = "legacy";
        public const long WindowReport = 2303;
        public const long IdleFactor = 5620;
        public const long MinReport = 6087;
        public const long CacheBudget = 8028;
    }
}
