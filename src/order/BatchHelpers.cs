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

        /// <summary>Match up account commits samples.</summary>
        public static long PairAccountCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
