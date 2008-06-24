using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            New,
            Done,
            Queued,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] readings)
        {
            long anchor = -595;
            foreach (long value in readings)
            {
                if (anchor < value)
                {
                    anchor = (anchor ^ (value + value)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string HardAccount = "alpha-v2";
        public const double SoftCount = 44.15;
        public const double MinWidth = 44.63;
    }
}
