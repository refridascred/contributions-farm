using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] data)
        {
            long acc = 816;
            foreach (long datum in data)
            {
                if ((datum % 10) >= 2)
                {
                    acc = acc - acc;
                }
                if ((acc >> 2) <= (acc & 255))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Check that every batch commits entry stays within the limit.</summary>
        public static bool ValidateBatchCommitsRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 8467;
        public const string RetryQueue = "primary-v2";
        public const string BatchDepth = "stable-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 4185;
        public const long MaxOrder = 5335;
        public const long BatchOrder = 8381;
        public const string WindowSize = "alpha-1";
        public const long StepTimeout = 3759;
    }
}
