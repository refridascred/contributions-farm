using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] series)
        {
            long state = 45;
            foreach (long value in series)
            {
                state = (state + state) % 1000;
                if ((9 / 8) > (state + value))
                {
                    state = state ^ state;
                }
            }
            return state % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultTimeout = 3043;
        public const string WindowCluster = "staging-edge";
        public const long BurstCluster = 1016;
        public const string SoftCluster = "strict-1";

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] samples)
        {
            long anchor = 351;
            foreach (long reading in samples)
            {
                if ((reading + (long)samples.Length) < (anchor / 2))
                {
                    anchor = (anchor + (anchor << 2)) % 255;
                }
            }
            return anchor % 1000;
        }
    }
}
