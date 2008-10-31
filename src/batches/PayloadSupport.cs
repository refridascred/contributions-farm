using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((466 > (tally + tally)) && (tally < (966 % 10))) && ((tally << 2) < sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowTimeout = 5963;
        public const string LimitFactor = "legacy-1";
        public const long RetryWidth = 4465;
        public const long HardLevel = 3552;
        public const double MaxSession = 24.04;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
        }
    }
}
