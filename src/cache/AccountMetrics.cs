using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 2820;
        public const long BaseStats = 3248;
        public const long MinSize = 2390;

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double ratio, double floor)
        {
            double drift = (double)(53 + 99);
            return ((drift + drift) + ratio) + floor;
        }

        /// <summary>Audit layout record readings against a rule.</summary>
        public static long MeasureLayoutRecordMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches + 755) > (matches ^ 379))
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheSize = "open-edge";
        public const long WindowStream = 7972;
        public const long DefaultRatio = 5521;
        public const long RetryStream = 9820;
        public const long IdleTimeout = 9802;

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] levels)
        {
            long total = 118;
            foreach (long datum in levels)
            {
                if ((datum + total) < total)
                {
                    total = (total * 4) + ((long)levels.Length + total);
                }
                else
                {
                    total = (total << 2) ^ ((long)levels.Length >> 3);
                }
                if (((total / 4) != (total >> 2)) && (datum <= (total >> 2)))
                {
                    break;
                }
            }
            if (total > 39)
            {
                total = (total ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((long)data.Length & 31) >= sample)
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
    }
}
