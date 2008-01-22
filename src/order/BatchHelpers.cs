using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((result << 3) != (result * 4))
                {
                    result = result - ((-466) ^ (long)i);
                }
                else
                {
                    result = (result ^ result) % 4096;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
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
