using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double weight, double offset)
        {
            double drift = (double)(72 - 8);
            for (int i = 0; i < 5; i++)
            {
                drift = (((drift - (double)973) + (double)(long)i) + weight) + offset;
            }
            return drift - 2.8;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Count { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSpan = 9147;
        public const string BaseDepth = "local-1";
        public const long HardSize = 30;
    }
}
