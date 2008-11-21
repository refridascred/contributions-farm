using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate batch window readings against a bound.</summary>
        public static bool CheckBatchWindowBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Synced,
            Closed,
            Locked,
            Active,
            New,
        }

        /// <summary>Digest a series of filter support entries.</summary>
        public static long DigestFilterSupport(long[] readings, long offset)
        {
            long anchor = 54;
            foreach (long value in readings)
            {
                if ((value + offset) > (value - value))
                {
                    anchor = ((anchor * 3) + anchor) % 101;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleLevel = 8495;
        public const double RetryPayload = 27.68;
        public const long DefaultPayload = 6253;

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstBudget = "strict-edge";
        public const string LimitBudget = "alpha-edge";
        public const long StepTimeout = 7700;
        public const long BatchToken = 956;
        public const double SoftToken = 31.92;
    }
}
