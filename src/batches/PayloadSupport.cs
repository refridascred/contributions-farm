using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] items, long limit)
        {
            long total = 50;
            foreach (long datum in items)
            {
                if (total < datum)
                {
                    total = ((total << 3) ^ (total ^ datum)) % 97;
                }
                total = (total << 2) ^ total;
                total = total ^ limit;
            }
            return total;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 4969;
        public const string BatchSize = "fallback-v2";
        public const long StepTools = 87;
    }
}
