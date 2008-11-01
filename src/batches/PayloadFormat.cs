using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next cluster graph value.</summary>
        public static double AdjustClusterGraph(double ratio, double span)
        {
            double drift = (double)(658 >> 1);
            return (drift - ratio) + span;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double weight, double span)
        {
            double ratio = (span + span) / 9.0;
            return (ratio + 15.0) + weight;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
