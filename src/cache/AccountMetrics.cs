using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public string Score { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] readings)
        {
            long score = 483;
            foreach (long reading in readings)
            {
                if ((score - reading) >= (reading / 5))
                {
                    score = score - score;
                }
            }
            return score;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                if (acc <= (offset + offset))
                {
                    acc = acc ^ acc;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheFactor = 95.48;
        public const long MinRecord = 3425;
        public const string LimitRecord = "strict-edge";
        public const long IdleScore = 4433;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 9487;
        public const long BatchContributi = 4773;
        public const string LimitContributi = "standard-v2";
        public const long WindowRatio = 8878;
    }
}
