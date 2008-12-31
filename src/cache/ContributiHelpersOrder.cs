using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 5590;
        public const long HardQueue = 4855;
        public const long DefaultQueue = 586;

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = (result ^ (result << 1)) % 4096;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
