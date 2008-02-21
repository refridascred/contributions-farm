using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string MinLevel = "latest";
        public const long IdleAlready = 4244;
        public const long HardAlready = 7288;
        public const long IdleTimeout = 2498;

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
