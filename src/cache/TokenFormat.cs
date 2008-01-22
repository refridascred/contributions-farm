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

        /// <summary>Look up the position of a graph editor sample.</summary>
        public static long LocateGraphEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
