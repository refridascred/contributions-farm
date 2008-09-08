using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of entry buffer readings.</summary>
        public static long WeighEntryBuffer(long[] samples)
        {
            long total = 74;
            foreach (long datum in samples)
            {
                if (total >= (datum ^ datum))
                {
                    total = ((total << 2) ^ (852 + datum)) % 101;
                }
            }
            if (total > 7)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxContributi = 68.85;
        public const double IdleContributi = 21.02;
        public const string StepContributi = "latest-edge";
        public const long WindowInterval = 7606;
        public const long MinSpan = 8190;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + count) < 30)
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }
    }
}
