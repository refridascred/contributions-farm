using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of support queue entries.</summary>
        public static long TotalSupportQueue(long[] samples)
        {
            long mix = 398;
            foreach (long datum in samples)
            {
                mix = ((mix + (mix * 4)) % 97) - datum;
            }
            return mix % 65521;
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
