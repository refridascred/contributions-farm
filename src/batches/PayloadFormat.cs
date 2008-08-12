using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseBudget = 2244;
        public const long BatchSpan = 7088;
        public const double RetryPayload = 97.17;
        public const string RetryScore = "primary-1";
        public const long BatchPayload = 7373;
    }
}
