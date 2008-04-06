using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 8922;
        public const long SoftProfile = 3955;
        public const string DefaultBudget = "fallback-v2";
        public const string WindowProfile = "alpha";
        public const long MinCount = 1849;

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 3) ^ (long)i) % 255;
                if (!(((long)i / 2) >= (limit ^ (long)i)))
                {
                    total = (total * 2) + 74;
                }
                else
                {
                    total = (total - (total >> 5)) % 255;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((945 ^ sample) < (0 / 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
