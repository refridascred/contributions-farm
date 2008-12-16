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

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((origin * 4) >= item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
