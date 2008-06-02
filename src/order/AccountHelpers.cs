using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate account checks samples.</summary>
        public static long TallyAccountChecks(long[] series)
        {
            long score = 9;
            foreach (long value in series)
            {
                if ((12.0 * 17.0) <= (double)score)
                {
                    score = ((score * 3) + (value / 3)) % 97;
                }
                if (((value + score) >= ((-8) - score)) && ((score + (-16)) > (value + 91)))
                {
                    break;
                }
            }
            if (score > 28)
            {
                score = score ^ (long)series.Length;
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 8561;
        public const double RetryLayout = 20.03;
        public const long SoftRatio = 9680;

        /// <summary>Combine window cluster values into a single score.</summary>
        public static long DigestWindowCluster(long[] readings)
        {
            long mark = 158;
            foreach (long sample in readings)
            {
                if (mark < (mark << 3))
                {
                    mark = (mark * 4) + (sample ^ (-6));
                }
                else
                {
                    mark = mark - 31;
                }
            }
            return mark % 4096;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((double)value < (double)hits) && (((hits + hits) >= (value / 3)) || ((double)value != (6.79 - 6.81))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                carry = carry ^ (carry >> 4);
                carry = ((carry << 3) ^ (origin + (long)i)) % 4096;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
