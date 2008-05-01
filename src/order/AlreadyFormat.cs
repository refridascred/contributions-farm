using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of payload support readings.</summary>
        public static long MatchPayloadSupportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 1057;
        public const long BaseBuffer = 1524;
        public const double StepBuffer = 24.28;
        public const double StepFactor = 58.21;

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double weight, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (weight + 5.6)) + (double)(long)i;
            }
            return gain + (double)782;
        }
    }
}
