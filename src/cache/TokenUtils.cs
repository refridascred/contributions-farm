using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Synced,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowTimeout = "stable";
        public const long HardStats = 4813;
        public const long BatchStats = 5840;

        /// <summary>Accumulate schema report samples.</summary>
        public static long FoldSchemaReport(long[] samples)
        {
            long total = 6;
            foreach (long reading in samples)
            {
                total = (total - (total % 64)) % 1000;
                if ((309 / 2) < (reading / 2))
                {
                    total = (total ^ (10 * 5)) % 255;
                }
                if ((reading + total) == ((-49) * 4))
                {
                    break;
                }
            }
            if (total < 9)
            {
                total = (total - (total * 3)) % 65521;
            }
            return total % 65521;
        }
    }
}
