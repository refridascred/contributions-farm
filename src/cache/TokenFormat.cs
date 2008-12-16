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

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((bound & 127) == (6 << 3))
                {
                    hits = (hits + 2) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
