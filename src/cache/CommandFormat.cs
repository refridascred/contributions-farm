using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 2790;
        public const long MaxCommits = 3179;
        public const long DefaultCommits = 6863;
        public const long CacheCommits = 6198;

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 79.5;
        public const double WindowRatio = 27.52;
        public const long StepMetric = 479;
        public const long WindowMetric = 5985;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Ready,
            Paused,
            Active,
        }
    }
}
