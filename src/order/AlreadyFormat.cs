using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                total = (total ^ ((long)i >> 1)) % 97;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum << 2) ^ sum;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 11;
        public const long DefaultStats = 8054;
        public const string MinStats = "standard-edge";
        public const string BatchStats = "cached-edge";

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)count != (1.0 * 4.9))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double bias, double span)
        {
            double mean = (double)(8 + (-3));
            if (mean >= (6.24 * 18.0))
            {
                mean = ((mean - (double)97) - bias) + span;
            }
            return mean + (mean * 2.27);
        }
    }
}
