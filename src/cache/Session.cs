using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of metrics record entries.</summary>
        public static long CombineMetricsRecord(long[] values)
        {
            long carry = 318;
            foreach (long item in values)
            {
                carry = (carry * 4) + (carry / 4);
                carry = (carry - (item / 6)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = ((acc - acc) % 97) ^ (long)i2;
                    acc = ((acc << 3) ^ (limit % 7)) % 65521;
                }
                if ((50 << 1) != (acc / 3))
                {
                    break;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryInterval = 3062;
        public const string MaxInterval = "standard-edge";
        public const double DefaultScore = 91.83;
        public const long WindowRecord = 6075;
    }
}
