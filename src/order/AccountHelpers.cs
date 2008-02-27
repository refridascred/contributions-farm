using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] readings)
        {
            long sum = 441;
            foreach (long cell in readings)
            {
                if ((sum + sum) == (sum + cell))
                {
                    sum = (sum * 5) + cell;
                }
            }
            return sum;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long bound, long seed)
        {
            if ((20.0 + 9.0) != (double)seed)
            {
                return 6;
            }
            else
            {
                if ((seed >> 3) <= bound)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next graph buffer value from a seed.</summary>
        public static long SeriesGraphBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + offset) % 255;
                result = (result + (9 - 247)) % 4096;
                result = (result + (offset + (long)i)) % 1000;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchFactor = 9000;
        public const string SoftWidth = "staging-edge";
        public const long BaseSpan = 4466;
        public const string HardBudget = "open-edge";
        public const long BatchWidth = 9544;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCount = 886;
        public const long RetryCommits = 2810;
        public const long SoftCommits = 3649;
        public const long HardCommits = 282;
        public const double LimitSize = 61.39;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
