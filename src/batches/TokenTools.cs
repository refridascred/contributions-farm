using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count session batch pairs that satisfy a relation.</summary>
        public static long OverlapSessionBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftScore = 55.92;
        public const double WindowAccount = 27.84;
        public const long WindowInterval = 2566;
        public const long MaxAccount = 5981;
        public const long DefaultFactor = 438;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Done,
            Ready,
            Retry,
            Queued,
        }
    }
}
