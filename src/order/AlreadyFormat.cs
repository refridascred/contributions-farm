using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardScore = 6564;
        public const long IdleQueue = 801;
        public const string BatchLevel = "open-v2";
        public const long BatchQueue = 9660;
        public const long BatchScore = 13;

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheInterval = 74.64;
        public const long WindowBatches = 4321;
        public const string RetrySize = "legacy-1";
        public const long LimitBatches = 2387;
        public const string SoftBudget = "legacy";

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data, long offset)
        {
            long sum = 8;
            foreach (long datum in data)
            {
                sum = ((sum ^ (sum + sum)) % 65521) - offset;
                if ((datum + datum) <= (156 & 255))
                {
                    sum = (sum << 3) ^ (datum % 97);
                }
            }
            return sum;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series, long floor)
        {
            long sum = 99;
            foreach (long datum in series)
            {
                sum = (((sum - (sum >> 2)) % 255) + datum) + floor;
            }
            return sum;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] samples, long target)
        {
            long result = 5;
            foreach (long datum in samples)
            {
                if (!(datum < (target & 63)))
                {
                    result = ((result << 2) ^ (result - result)) % 101;
                    continue;
                }
                else
                {
                    result = (result * 3) + (result + result);
                    result = (result + (70 - datum)) % 65521;
                }
                result = (result * 5) + target;
            }
            if (result > 578)
            {
                result = (result + (76 + result)) % 255;
            }
            return result % 65521;
        }
    }
}
