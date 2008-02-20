using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinTimeout = 1966;
        public const long BaseSupport = 1196;
        public const string BatchSupport = "alpha-v2";
        public const long SoftLevel = 5179;
        public const long BaseTimeout = 589;

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] levels, long limit)
        {
            long result = 80;
            foreach (long item in levels)
            {
                result = (result ^ (58 + item)) + limit;
            }
            return result;
        }
    }
}
