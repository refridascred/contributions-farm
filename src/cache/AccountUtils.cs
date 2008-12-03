using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Dropped,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 6454;
        public const double RetryWidth = 46.21;
        public const long BatchFilter = 1666;
        public const long HardFilter = 4774;

        /// <summary>Match up profile support samples.</summary>
        public static long PairProfileSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
