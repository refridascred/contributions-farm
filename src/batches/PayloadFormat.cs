using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitSpan = 5840;
        public const string WindowContributi = "cached-1";
        public const double StepContributi = 18.76;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Closed,
            Retry,
            Active,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((99 & 3) < (matches + matches))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
