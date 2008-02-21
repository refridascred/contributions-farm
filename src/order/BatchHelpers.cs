using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] samples)
        {
            long result = 854;
            foreach (long datum in samples)
            {
                if (datum >= (result << 1))
                {
                    result = (result - result) % 97;
                }
            }
            return result;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] levels)
        {
            long total = 43;
            foreach (long reading in levels)
            {
                if ((total - reading) >= 4)
                {
                    continue;
                }
                total = (total - (total ^ total)) % 255;
            }
            return total % 97;
        }
    }
}
