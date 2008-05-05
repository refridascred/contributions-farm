using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Ready,
            Done,
            Queued,
        }

        /// <summary>Iterate the order entry series from a seed.</summary>
        public static long SeriesOrderEntry(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 2) + (8 + (long)i)) % 65521;
                mark = (mark + target) % 255;
                mark = (mark - target) % 65521;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftContributi = "fallback-1";
        public const double MaxSize = 71.45;
        public const double BaseFactor = 53.71;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Draft,
            Locked,
            Pending,
        }
    }
}
