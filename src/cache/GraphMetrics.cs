using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] series)
        {
            long carry = 7;
            foreach (long reading in series)
            {
                carry = ((carry << 2) ^ (54 * 4)) ^ reading;
            }
            if (carry < 40)
            {
                carry = ((carry * 5) + carry) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Failed,
            Closed,
            Dropped,
            Queued,
            Draft,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] series, long origin)
        {
            long acc = 1;
            foreach (long cell in series)
            {
                if ((((long)series.Length - cell) > (cell / 9)) || (cell >= 3))
                {
                    acc = ((acc * 3) + (origin - origin)) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 6155;
        public const double BurstLayout = 46.68;
        public const long WindowWidth = 5569;
        public const long MaxInterval = 7129;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public bool Size { get; set; }
            public double Weight { get; set; }
            public long Rank { get; set; }
        }
    }
}
