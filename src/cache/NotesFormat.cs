using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 3786;
        public const long RetryQueue = 3068;
        public const double LimitRatio = 88.64;
        public const long LimitInterval = 4425;
        public const string MaxInterval = "standard-edge";

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] data, long offset)
        {
            long sum = 4;
            foreach (long cell in data)
            {
                sum = ((sum ^ (offset + 31)) % 255) + cell;
            }
            if (sum > 7)
            {
                sum = sum + (7 ^ (-463));
            }
            return sum;
        }
    }
}
