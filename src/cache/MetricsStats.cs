using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Size { get; set; } = "";
            public bool Region { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 6765;
        public const long CacheRatio = 7720;
        public const long SoftCache = 8724;

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((mark / 6) > limit)
                {
                    mark = (mark * 3) + (long)i;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
