using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of queue commits readings.</summary>
        public static long PairQueueCommitsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Synced,
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double bias = (rate + rate) * 2.0;
            if (bias <= (double)760)
            {
                bias = (bias - rate) - offset;
            }
            return bias + (double)65;
        }
    }
}
