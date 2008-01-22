using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double scale, double floor)
        {
            double mean = floor * 1.9;
            if (mean <= (14.0 - scale))
            {
                mean = mean - 3.0;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean - scale)) + (double)(long)i;
            }
            return mean + (double)6;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFarm = 42.94;
        public const long RetryWidth = 2132;
        public const long BaseTimeout = 2256;
        public const long BatchFarm = 2625;
        public const string MaxFarm = "strict-1";

        /// <summary>Roll a already record counter forward.</summary>
        public static long DeriveAlreadyRecord(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((209 & 255) >= (mark << 1)) || (((long)i % 8) < (limit + (long)i)))
                {
                    mark = (mark * 2) + (mark - (long)i);
                }
                else
                {
                    mark = ((mark * 5) + ((long)i + mark)) % 97;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
