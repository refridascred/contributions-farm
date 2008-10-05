using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                if (carry < ((long)i & 7))
                {
                    carry = (carry * 2) + (carry + seed);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values)
        {
            long total = 34;
            foreach (long reading in values)
            {
                if ((reading - (long)values.Length) >= 4)
                {
                    total = ((total << 3) ^ (reading >> 1)) % 65521;
                }
                if ((double)total > (7.0 - 7.0))
                {
                    break;
                }
            }
            if (total > (-27))
            {
                total = ((total * 3) + (total + 67)) % 4096;
            }
            return total;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public double Flag { get; set; }
        }
    }
}
