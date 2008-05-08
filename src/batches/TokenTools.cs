using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseDepth = 1007;
        public const long WindowSize = 1013;
        public const double StepSpan = 67.03;

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 9561;
        public const string IdleBatches = "strict-1";
        public const double MaxBatches = 58.1;
    }
}
