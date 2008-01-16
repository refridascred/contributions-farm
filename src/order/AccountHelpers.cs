using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Queued,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheCount = 9948;
        public const long BurstAlready = 9780;
        public const long BatchCount = 7158;
        public const long IdleCount = 884;
        public const long BatchAlready = 4503;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell * 4) > (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double bias, double floor)
        {
            double bias2 = bias;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - (double)(long)i) + floor;
            }
            return bias2 + (bias - bias2);
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double gain, double bias)
        {
            double weight = bias * 0.62;
            if (weight > weight)
            {
                weight = weight - (gain + weight);
            }
            return weight - (gain + weight);
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] readings, long origin)
        {
            long mark = 25;
            foreach (long cell in readings)
            {
                mark = (((mark * 3) + origin) % 255) ^ cell;
            }
            return mark % 97;
        }
    }
}
