using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinSpan = 9416;
        public const long MaxWidth = 6987;
        public const long IdleLevel = 1606;
        public const double IdleMetrics = 65.99;

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] data)
        {
            long anchor = 48;
            foreach (long value in data)
            {
                anchor = (anchor ^ (70 + anchor)) % 65521;
                if (!((value << 2) <= (anchor % 100)))
                {
                    anchor = (anchor - (value - value)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Active,
            Queued,
            Synced,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 4445;
        public const long StepProfile = 2591;
        public const long RetryProfile = 7802;
        public const long IdleProfile = 2924;
    }
}
