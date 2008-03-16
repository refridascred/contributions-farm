using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of context metrics readings.</summary>
        public static long PairContextMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowRatio = 1772;
        public const string IdleFactor = "strict";
        public const long MaxScore = 3062;
        public const long StepNotes = 3061;
        public const long IdleScore = 2588;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
