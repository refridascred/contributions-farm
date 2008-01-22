using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next already stream value.</summary>
        public static double ScaleAlreadyStream(double scale, double bias)
        {
            double load = (double)(13 & 127);
            return (load - bias) + scale;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
