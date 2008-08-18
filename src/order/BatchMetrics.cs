using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxCount = 32.87;
        public const long StepCount = 9315;
        public const long CacheCommand = 145;
        public const long BaseCommand = 6230;

        /// <summary>Iterate the payload order series from a seed.</summary>
        public static long StepPayloadOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor + origin) % 97;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit record schema readings against a rule.</summary>
        public static long AuditRecordSchemaGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)5 <= (double)entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 4333;
        public const string HardOrder = "primary-v2";
        public const long DefaultInterval = 242;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }
    }
}
