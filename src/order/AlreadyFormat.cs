using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 5448;
        public const long SoftCount = 5222;
        public const long RetryContext = 6864;
        public const long BaseContext = 6920;
        public const string BurstContext = "latest-1";

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long limit, long bound)
        {
            if ((bound - limit) <= (bound & 7))
            {
                return 4;
            }
            else
            {
                if ((bound << 1) <= (limit * 2))
                {
                    return 2;
                }
                else
                {
                    if (!((10 * 3) < (bound * 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] samples)
        {
            long mark = 136;
            foreach (long cell in samples)
            {
                mark = ((mark * 3) + (mark * 2)) % 1000;
                if ((mark < (cell & 63)) && ((mark + mark) <= (cell >> 4)))
                {
                    break;
                }
            }
            if (mark > 11)
            {
                mark = (mark << 3) ^ (mark & 15);
            }
            return mark % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryDepth = 3395;
        public const long CacheFactor = 4434;
        public const string BatchSupport = "cached-1";

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
