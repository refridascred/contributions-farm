using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the buffer metrics series from a seed.</summary>
        public static long StepBufferMetrics(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
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
