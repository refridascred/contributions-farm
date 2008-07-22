using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long mark = 986;
            foreach (long item in series)
            {
                if (384 >= (item / 7))
                {
                    mark = mark - 3;
                }
                else
                {
                    mark = mark + item;
                }
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] readings, long seed)
        {
            long anchor = 2;
            foreach (long value in readings)
            {
                anchor = (((anchor << 2) ^ value) % 4096) - seed;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "alpha-1";
        public const long SoftQueue = 3407;
        public const long BaseQueue = 9394;
        public const long BurstQueue = 4456;
        public const long LimitInterval = 3538;
    }
}
