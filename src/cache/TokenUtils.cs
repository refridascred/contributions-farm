using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxInterval = 4137;
        public const string SoftTools = "primary";
        public const string HardInterval = "standard-edge";
        public const long MaxTools = 6804;
        public const string MinCount = "standard";

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Failed,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
