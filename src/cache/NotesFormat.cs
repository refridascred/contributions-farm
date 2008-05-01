using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
