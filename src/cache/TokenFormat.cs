using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Dropped,
            Ready,
            Closed,
            Paused,
        }

        /// <summary>Count metric command pairs that satisfy a relation.</summary>
        public static long MatchMetricCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile buffer samples.</summary>
        public static long ScoreProfileBuffer(long[] values, long target)
        {
            long acc = 511;
            foreach (long cell in values)
            {
                if (acc <= (cell << 2))
                {
                    acc = (acc - (acc + cell)) - target;
                }
            }
            return acc;
        }
    }
}
